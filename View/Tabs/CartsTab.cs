using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Customer _currentCustomer;
        private List<Item> _items = new();
        private List<Customer> _customers = new();

        // Элементы для скидок (создаются программно)
        private Panel discountsPanel;
        private CheckedListBox discountsCheckedListBox;
        private Label discountAmountLabel;
        private Label totalLabel;
        private Label discountsTextLabel;
        private Label discountAmountTextLabel;
        private Label totalTextLabel;

        private double _currentDiscount;

        public CartsTab()
        {
            InitializeComponent();
            InitializeDiscountsPanel();
        }

        private void InitializeDiscountsPanel()
        {
            discountsPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 180,
                BorderStyle = BorderStyle.FixedSingle
            };

            discountsTextLabel = new Label
            {
                Text = "Применить скидки:",
                Location = new Point(10, 10),
                AutoSize = true
            };

            discountsCheckedListBox = new CheckedListBox
            {
                Location = new Point(10, 30),
                Size = new Size(300, 120),
                CheckOnClick = true
            };
            discountsCheckedListBox.ItemCheck += DiscountsCheckedListBox_ItemCheck;

            discountAmountTextLabel = new Label
            {
                Text = "Сумма скидки:",
                Location = new Point(320, 30),
                AutoSize = true
            };

            discountAmountLabel = new Label
            {
                Text = "0,00 ₽",
                Location = new Point(420, 30),
                AutoSize = true
            };

            totalTextLabel = new Label
            {
                Text = "Итого к оплате:",
                Location = new Point(320, 60),
                AutoSize = true
            };

            totalLabel = new Label
            {
                Text = "0,00 ₽",
                Location = new Point(420, 60),
                AutoSize = true,
                Font = new Font(Font, FontStyle.Bold)
            };

            discountsPanel.Controls.Add(discountsTextLabel);
            discountsPanel.Controls.Add(discountsCheckedListBox);
            discountsPanel.Controls.Add(discountAmountTextLabel);
            discountsPanel.Controls.Add(discountAmountLabel);
            discountsPanel.Controls.Add(totalTextLabel);
            discountsPanel.Controls.Add(totalLabel);

            Controls.Add(discountsPanel);
            discountsPanel.BringToFront();

            CartSplitContainer.Location = new Point(0, 180);
            CartSplitContainer.Height = Height - 180;
        }

        // ========== НОВЫЕ МЕТОДЫ ДЛЯ СКИДОК ==========
        private void UpdateDiscountsList()
        {
            discountsCheckedListBox.Items.Clear();

            if (_currentCustomer?.Discounts == null)
                return;

            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                discountsCheckedListBox.Items.Add(discount, true);
            }

            UpdateDiscountDisplay();
        }

        private void UpdateDiscountDisplay()
        {
            if (_currentCustomer == null || _currentCustomer.Cart.Items.Count == 0)
            {
                discountAmountLabel.Text = "0,00 ₽";
                totalLabel.Text = _currentCustomer?.Cart.Amount.ToString("F2") + " ₽" ?? "0,00 ₽";
                return;
            }

            double discountSum = 0;

            foreach (IDiscount discount in discountsCheckedListBox.CheckedItems)
            {
                discountSum += discount.Calculate(_currentCustomer.Cart.Items);
            }

            _currentDiscount = discountSum;

            double totalAmount = _currentCustomer.Cart.Amount;
            double finalTotal = totalAmount - discountSum;

            discountAmountLabel.Text = discountSum.ToString("F2") + " ₽";
            totalLabel.Text = finalTotal.ToString("F2") + " ₽";
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)UpdateDiscountDisplay);
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Добавьте товары в корзину!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalDiscount = 0;

            foreach (IDiscount discount in discountsCheckedListBox.CheckedItems)
            {
                totalDiscount += discount.Apply(_currentCustomer.Cart.Items);
            }

            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }

            Order order = _currentCustomer.IsPriority
                ? new PriorityOrder(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items),
                    DateTime.Now.AddDays(1),
                    "9:00 - 11:00")
                : new Order(
                    _currentCustomer.Address,
                    new List<Item>(_currentCustomer.Cart.Items));

            order.DiscountAmount = totalDiscount;

            _currentCustomer.Orders.Add(order);
            _currentCustomer.Cart.Items.Clear();

            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountsList();

            MessageBox.Show(
                $"Заказ создан!\nСкидка: {totalDiscount:F2} ₽",
                "Успех",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ========== ТВОИ СУЩЕСТВУЮЩИЕ МЕТОДЫ ==========
        private void UpdateItemsListBox(int index)
        {
            var items = Items;
            ItemsListBox.Items.Clear();

            foreach (var item in items)
            {
                ItemsListBox.Items.Add(item.Name != "" ? item.Name : $"Item {item.ID}");
            }

            if (-1 <= index && index < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = index;
            }
        }

        private void UpdateCartListBox(int index)
        {
            CartListBox.Items.Clear();
            if (CustomersComboBox.SelectedIndex == -1) return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            var items = _currentCustomer.Cart.Items;

            if (items == null) return;

            foreach (var item in items)
            {
                CartListBox.Items.Add(item.Name != "" ? item.Name : $"Item {item.ID}");
            }

            UpdateAmountLabel();
            UpdateDiscountDisplay();
        }

        private void UpdateComboBox(int index)
        {
            CustomersComboBox.Items.Clear();
            foreach (var customer in Customers)
            {
                CustomersComboBox.Items.Add(customer.FullName != "" ? customer.FullName : $"Customer {customer.ID}");
            }

            if (-1 <= index && index < CustomersComboBox.Items.Count)
            {
                CustomersComboBox.SelectedIndex = index;
            }
        }

        private void UpdateAmountLabel()
        {
            AmountLabel.Text = _currentCustomer == null ? "0,00" : _currentCustomer.Cart.Amount.ToString("f");
        }

        // ========== ПРОПЕРТИ ==========
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        public void RefreshData()
        {
            _currentCustomer = null;
            UpdateItemsListBox(-1);
            UpdateComboBox(-1);
            UpdateCartListBox(-1);
            UpdateDiscountsList();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1)
                return;

            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountsList();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || _currentCustomer == null) return;
            _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1 || _currentCustomer == null) return;
            _currentCustomer.Cart.Items.Remove(_currentCustomer.Cart.Items[CartListBox.SelectedIndex]);
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;
            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
        }
    }
}
