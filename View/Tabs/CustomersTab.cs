using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;
using ObjectOrientedPractics.Model.Discounts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new();
        private Customer? _currentCustomer;

        private ListBox DiscountsListBox;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
        private Label DiscountsLabel;
        private Panel DiscountsPanel;

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                UpdateCustomersListBox();
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
            InitializeDiscountsPanel();
        }

        private void InitializeDiscountsPanel()
        {
            DiscountsPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle
            };

            DiscountsLabel = new Label
            {
                Text = "Скидки покупателя:",
                Location = new Point(10, 10),
                AutoSize = true
            };

            DiscountsListBox = new ListBox
            {
                Location = new Point(10, 30),
                Size = new Size(300, 80),
                SelectionMode = SelectionMode.One
            };

            AddDiscountButton = new Button
            {
                Text = "Добавить",
                Location = new Point(320, 30),
                Size = new Size(100, 30)
            };
            AddDiscountButton.Click += AddDiscountButton_Click;

            RemoveDiscountButton = new Button
            {
                Text = "Удалить",
                Location = new Point(320, 70),
                Size = new Size(100, 30)
            };
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;

            DiscountsPanel.Controls.Add(DiscountsLabel);
            DiscountsPanel.Controls.Add(DiscountsListBox);
            DiscountsPanel.Controls.Add(AddDiscountButton);
            DiscountsPanel.Controls.Add(RemoveDiscountButton);

            Controls.Add(DiscountsPanel);
            DiscountsPanel.BringToFront();
        }

        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add(customer.FullName);
            }
        }

        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();

            if (customer?.Discounts == null)
                return;

            foreach (var discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount);
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using AddDiscountForm form = new();

            if (form.ShowDialog() == DialogResult.OK)
            {
                _currentCustomer.Discounts.Add(
                    new PercentDiscount(form.SelectedCategory));

                UpdateDiscountsListBox(_currentCustomer);
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
                return;

            if (DiscountsListBox.SelectedItem is not IDiscount selectedDiscount)
            {
                MessageBox.Show("Выберите скидку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedDiscount is PointsDiscount)
            {
                MessageBox.Show("Накопительную скидку удалить нельзя!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentCustomer.Discounts.Remove(selectedDiscount);
            UpdateDiscountsListBox(_currentCustomer);
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("None");
            _customers.Add(_currentCustomer);

            CustomersListBox.Items.Add(_currentCustomer.FullName);
            CustomersListBox.SelectedIndex = _customers.Count - 1;

            UpdateTextBoxes(_currentCustomer);
            UpdateDiscountsListBox(_currentCustomer);
        }

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
                return;

            int index = CustomersListBox.SelectedIndex;
            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > 0)
                CustomersListBox.SelectedIndex = Math.Min(index, CustomersListBox.Items.Count - 1);
            else
            {
                ClearTextBoxes();
                _currentCustomer = null;
            }
        }

        private void ClearTextBoxes()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.ClearInfo();
        }

        private void UpdateTextBoxes(Customer customer)
        {
            IDTextBox.Text = customer.ID.ToString();
            FullNameTextBox.Text = customer.FullName;
            AddressControl.Address = customer.Address;
        }

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
                return;

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            UpdateTextBoxes(_currentCustomer);
            UpdateDiscountsListBox(_currentCustomer);
        }

        private void FullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
                return;

            try
            {
                ValueValidator.AssertStringOnlengs(
                    FullNameTextBox.Text, 200, "Название");

                _currentCustomer.FullName = FullNameTextBox.Text;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] =
                    _currentCustomer.FullName;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
