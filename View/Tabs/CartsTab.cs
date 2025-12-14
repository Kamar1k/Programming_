using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private double _currentDiscount = 0.0;

        public CartsTab()
        {
            InitializeComponent();
            InitializeDiscountsPanel(); // Создаем панель скидок
        }

        private void InitializeDiscountsPanel()
        {
            // 1. Панель для скидок
            discountsPanel = new Panel();
            discountsPanel.Dock = DockStyle.Top;
            discountsPanel.Height = 180;
            discountsPanel.BorderStyle = BorderStyle.FixedSingle;

            // 2. Надпись "Применить скидки"
            discountsTextLabel = new Label();
            discountsTextLabel.Text = "Применить скидки:";
            discountsTextLabel.Location = new Point(10, 10);
            discountsTextLabel.AutoSize = true;

            // 3. CheckedListBox для выбора скидок
            discountsCheckedListBox = new CheckedListBox();
            discountsCheckedListBox.Location = new Point(10, 30);
            discountsCheckedListBox.Size = new Size(300, 120);
            discountsCheckedListBox.CheckOnClick = true;
            discountsCheckedListBox.ItemCheck += DiscountsCheckedListBox_ItemCheck;

            // 4. Надпись "Сумма скидки"
            discountAmountTextLabel = new Label();
            discountAmountTextLabel.Text = "Сумма скидки:";
            discountAmountTextLabel.Location = new Point(320, 30);
            discountAmountTextLabel.AutoSize = true;

            discountAmountLabel = new Label();
            discountAmountLabel.Text = "0,00 ₽";
            discountAmountLabel.Location = new Point(420, 30);
            discountAmountLabel.AutoSize = true;

            // 5. Надпись "Итого к оплате"
            totalTextLabel = new Label();
            totalTextLabel.Text = "Итого к оплате:";
            totalTextLabel.Location = new Point(320, 60);
            totalTextLabel.AutoSize = true;

            totalLabel = new Label();
            totalLabel.Text = "0,00 ₽";
            totalLabel.Location = new Point(420, 60);
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font(totalLabel.Font, FontStyle.Bold);

            // 6. Добавляем элементы на панель
            discountsPanel.Controls.Add(discountsTextLabel);
            discountsPanel.Controls.Add(discountsCheckedListBox);
            discountsPanel.Controls.Add(discountAmountTextLabel);
            discountsPanel.Controls.Add(discountAmountLabel);
            discountsPanel.Controls.Add(totalTextLabel);
            discountsPanel.Controls.Add(totalLabel);

            // 7. Добавляем панель на форму (ПЕРЕД основным контейнером)
            this.Controls.Add(discountsPanel);
            discountsPanel.BringToFront();

            // 8. Смещаем основной контейнер вниз
            CartSplitContainer.Location = new Point(0, 180);
            CartSplitContainer.Height = this.Height - 180;
        }

        // Методы для работы со скидками
        private void UpdateDiscountsList()
        {
            if (discountsCheckedListBox == null) return;

            discountsCheckedListBox.Items.Clear();
            if (_currentCustomer?.Discounts != null)
            {
                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    discountsCheckedListBox.Items.Add(discount.Info, true);
                }
            }
            UpdateDiscountDisplay();
        }

        private void UpdateDiscountDisplay()
        {
            if (_currentCustomer == null || _currentCustomer.Cart.Items?.Count == 0)
            {
                discountAmountLabel.Text = "0,00 ₽";
                totalLabel.Text = _currentCustomer?.Cart.Amount.ToString("F2") + " ₽" ?? "0,00 ₽";
                return;
            }

            double discountSum = 0.0;
            for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
            {
                if (discountsCheckedListBox.GetItemChecked(i))
                {
                    discountSum += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }

            _currentDiscount = discountSum;
            double totalAmount = _currentCustomer.Cart.Amount;
            double finalTotal = totalAmount - discountSum;

            discountAmountLabel.Text = discountSum.ToString("F2") + " ₽";
            totalLabel.Text = finalTotal.ToString("F2") + " ₽";
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                UpdateDiscountDisplay();
            });
        }

        // --- ОСТАЛЬНЫЕ МЕТОДЫ (ваш существующий код с небольшими изменениями) ---

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
            UpdateDiscountDisplay(); // ОБНОВЛЕНО
        }

        private void UpdateAmountLabel()
        {
            AmountLabel.Text = _currentCustomer == null ? "0,00" : _currentCustomer.Cart.Amount.ToString("f");
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
            UpdateDiscountsList(); // ОБНОВЛЕНО
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            if (CustomersComboBox.SelectedIndex == -1) return;
            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            UpdateDiscountsList(); // ДОБАВЛЕНО
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

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            var cartItems = _currentCustomer.Cart.Items;
            if (cartItems == null || cartItems.Count == 0)
            {
                MessageBox.Show("Добавьте товары в корзину!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Рассчитываем итоговую скидку
            double totalDiscount = 0.0;
            for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
            {
                if (discountsCheckedListBox.GetItemChecked(i))
                {
                    totalDiscount += _currentCustomer.Discounts[i].Apply(cartItems);
                }
            }

            // 2. Обновляем ВСЕ скидки покупателя
            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                discount.Update(cartItems);
            }

            // 3. Создаем заказ
            Order newOrder;
            if (_currentCustomer.IsPriority)
            {
                newOrder = new PriorityOrder(
                    _currentCustomer.Address,
                    new List<Item>(cartItems),
                    DateTime.Now.AddDays(1),
                    "9:00 - 11:00"
                );
            }
            else
            {
                newOrder = new Order(_currentCustomer.Address, new List<Item>(cartItems));
            }

            // 4. Сохраняем размер скидки в заказе
            newOrder.DiscountAmount = totalDiscount;

            // 5. Добавляем заказ и очищаем корзину
            _currentCustomer.Orders.Add(newOrder);
            _currentCustomer.Cart.Items.Clear();

            // 6. Обновляем интерфейс
            UpdateCartListBox(CustomersComboBox.SelectedIndex);
            UpdateDiscountsList();

            MessageBox.Show($"Заказ создан!\nСкидка: {totalDiscount:F2} ₽", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}