using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms; // Важно: добавить для AddDiscountForm
using ObjectOrientedPractics.Model.Discounts; // Важно: добавить для IDiscount
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список всех покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель
        /// </summary>
        private Customer? _currentCustomer;

        // --- НОВЫЕ ПОЛЯ ДЛЯ РАБОТЫ СО СКИДКАМИ ---
        private ListBox DiscountsListBox;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
        private Label DiscountsLabel;
        private Panel DiscountsPanel;

        /// <summary>
        /// Возвращает или задает список покупателей вкладки.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateCustomersListBox();
            }
        }

        /// <summary>
        /// Обновляет список покупателей в ListBox.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add(customer.FullName);
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
            InitializeDiscountsPanel(); // ДОБАВЛЕНО: инициализация панели скидок
        }

        /// <summary>
        /// Инициализирует панель для управления скидками покупателя.
        /// </summary>
        private void InitializeDiscountsPanel()
        {
            // 1. Создаем основную панель для скидок
            DiscountsPanel = new Panel();
            DiscountsPanel.Dock = DockStyle.Top;
            DiscountsPanel.Height = 150;
            DiscountsPanel.BorderStyle = BorderStyle.FixedSingle;

            // 2. Создаем и настраиваем Label
            DiscountsLabel = new Label();
            DiscountsLabel.Text = "Скидки покупателя:";
            DiscountsLabel.Location = new Point(10, 10);
            DiscountsLabel.AutoSize = true;

            // 3. Создаем и настраиваем ListBox для отображения скидок
            DiscountsListBox = new ListBox();
            DiscountsListBox.Location = new Point(10, 30);
            DiscountsListBox.Size = new Size(300, 80);
            DiscountsListBox.SelectionMode = SelectionMode.One;

            // 4. Создаем и настраиваем кнопку "Добавить"
            AddDiscountButton = new Button();
            AddDiscountButton.Text = "Добавить";
            AddDiscountButton.Location = new Point(320, 30);
            AddDiscountButton.Size = new Size(100, 30);
            AddDiscountButton.Click += AddDiscountButton_Click;

            // 5. Создаем и настраиваем кнопку "Удалить"
            RemoveDiscountButton = new Button();
            RemoveDiscountButton.Text = "Удалить";
            RemoveDiscountButton.Location = new Point(320, 70);
            RemoveDiscountButton.Size = new Size(100, 30);
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;

            // 6. Добавляем все элементы на панель
            DiscountsPanel.Controls.Add(DiscountsLabel);
            DiscountsPanel.Controls.Add(DiscountsListBox);
            DiscountsPanel.Controls.Add(AddDiscountButton);
            DiscountsPanel.Controls.Add(RemoveDiscountButton);

            // 7. Добавляем панель на основную форму (UserControl)
            this.Controls.Add(DiscountsPanel);

            // 8. Поднимаем панель наверх, чтобы она отображалась правильно
            DiscountsPanel.BringToFront();
        }

        /// <summary>
        /// Обновляет список скидок в DiscountsListBox для указанного покупателя.
        /// </summary>
        /// <param name="customer">Покупатель, скидки которого нужно отобразить.</param>
        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();
            if (customer?.Discounts != null)
            {
                foreach (IDiscount discount in customer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }
            }
        }

        // --- ОБРАБОТЧИКИ СОБЫТИЙ ДЛЯ СКИДОК ---

        /// <summary>
        /// Обрабатывает нажатие кнопки "Добавить" для скидки.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите покупателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = _customers[CustomersListBox.SelectedIndex];
            AddDiscountForm form = new AddDiscountForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                customer.AddPercentDiscount(form.SelectedCategory);
                UpdateDiscountsListBox(customer);
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Удалить" для скидки.
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите покупателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DiscountsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите скидку для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = _customers[CustomersListBox.SelectedIndex];

            if (customer.RemoveDiscount(DiscountsListBox.SelectedIndex))
            {
                UpdateDiscountsListBox(customer);
            }
            else
            {
                MessageBox.Show("Накопительную скидку удалить нельзя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- СУЩЕСТВУЮЩИЕ МЕТОДЫ (ОБНОВЛЕНЫ) ---

        /// <summary>
        /// Обрабатывает событие нажатия кнопки добавления покупателя.
        /// </summary>
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("None");
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateTextBoxes(_currentCustomer);
            UpdateDiscountsListBox(_currentCustomer); // ДОБАВЛЕНО: обновляем скидки
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки удаления покупателя.
        /// </summary>
        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1) return;

            int index = CustomersListBox.SelectedIndex;
            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            if (CustomersListBox.Items.Count > index)
                CustomersListBox.SelectedIndex = index;
            else if (CustomersListBox.Items.Count != 0)
                CustomersListBox.SelectedIndex = 0;
            else
            {
                CustomersListBox.SelectedIndex = -1;
                ClearTextBoxes();
                _currentCustomer = null;
            }
        }

        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.ClearInfo();
            _currentCustomer = null;
        }

        /// <summary>
        /// Обновляет значения текстовых полей данными указанного покупателя.
        /// </summary>
        /// <param name="customer">Покупатель, данные которого отображаются.</param>
        private void UpdateTextBoxes(Customer customer)
        {
            IDTextBox.Text = customer.ID.ToString();
            FullNameTextBox.Text = customer.FullName;
            AddressControl.Address = customer.Address;
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного покупателя в списке.
        /// </summary>
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index == -1) return;
            _currentCustomer = _customers[index];
            UpdateTextBoxes(_currentCustomer);
            UpdateDiscountsListBox(_currentCustomer); // ДОБАВЛЕНО: обновляем скидки
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле полного имени покупателя.
        /// </summary>
        private void FullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;
            try
            {
                ValueValidator.AssertStringOnlengs(FullNameTextBox.Text, 200, "Название");
                _currentCustomer.FullName = FullNameTextBox.Text;
                int index = _customers.IndexOf(_currentCustomer);
                if (index != -1 && index < CustomersListBox.Items.Count)
                {
                    CustomersListBox.Items[index] = _currentCustomer.FullName;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}