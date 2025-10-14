using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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

        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки добавления покупателя.
        /// </summary>
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("None", "None");
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateTextBoxes(_currentCustomer);
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
            AddressTextBox.Clear();
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
            AddressTextBox.Text = customer.Address;
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
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле полного имени покупателя.
        /// </summary>
        private void FullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;
            try
            {

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

        /// <summary>
        /// Обрабатывает изменение текста в поле адреса покупателя.
        /// </summary>
        private void AddressTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;
            try
            {

                _currentCustomer.Address = AddressTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
