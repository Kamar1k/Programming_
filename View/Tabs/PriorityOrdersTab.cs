using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        private PriorityOrder _currentPriorityOrder;
        private Random _randomForAddItem;

        public PriorityOrdersTab()
        {
            InitializeComponent();

            _currentPriorityOrder = new PriorityOrder();
            _currentPriorityOrder.Items = new List<Item>();
            _currentPriorityOrder.Address = new Address();

            // Инициализация UI элементов
            IDSelectedOrderTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedSelectedOrderTextBox.Text = _currentPriorityOrder.Date.ToString();
            AmountSelectedOrderLabel.Text = _currentPriorityOrder.Amount.ToString("F2"); // ИСПРАВЛЕНО: AmountOrder → Amount

            // Заполнение ComboBox для времени доставки
            foreach (var time in _deliveryTime)
            {
                DeliveryTimeSelectedOrderComboBox.Items.Add(time);
            }
            DeliveryTimeSelectedOrderComboBox.SelectedIndex = 0;

            // Заполнение ComboBox для статуса заказа
            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatusValues)
            {
                StatusSelectedOrderComboBox.Items.Add(status);
            }
            StatusSelectedOrderComboBox.SelectedIndex = 0;

            SelectedOrderAddressControl.Address = _currentPriorityOrder.Address;
            _randomForAddItem = new Random();
        }

        public List<Item> Items { get; set; }

        /// <summary>
        /// Создает новый приоритетный заказ.
        /// </summary>
        private void CreateNewPriorityOrder()
        {
            _currentPriorityOrder = new PriorityOrder();
            _currentPriorityOrder.Items = new List<Item>();
            _currentPriorityOrder.Address = new Address();

            // Обновление UI
            SelectedOrderAddressControl.Address = _currentPriorityOrder.Address;
            IDSelectedOrderTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedSelectedOrderTextBox.Text = _currentPriorityOrder.Date.ToString();
            DeliveryTimeSelectedOrderComboBox.SelectedIndex = 0;
            StatusSelectedOrderComboBox.SelectedIndex = 0;
            OrderItemsListBox.Items.Clear();
            AmountSelectedOrderLabel.Text = _currentPriorityOrder.Amount.ToString("F2"); // ИСПРАВЛЕНО: AmountOrder → Amount
        }

        private void StatusSelectedOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder != null && StatusSelectedOrderComboBox.SelectedItem != null)
            {
                _currentPriorityOrder.Status = (OrderStatus)StatusSelectedOrderComboBox.SelectedItem; // ИСПРАВЛЕНО: OrderStatus → Status
            }
        }

        private void DeliveryTimeSelectedOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder != null && DeliveryTimeSelectedOrderComboBox.SelectedItem != null)
            {
                _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeSelectedOrderComboBox.SelectedItem;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (Items == null || Items.Count == 0)
            {
                MessageBox.Show("Нет доступных товаров для добавления.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Item item = Items[_randomForAddItem.Next(Items.Count)];
                _currentPriorityOrder.Items.Add(item);
                OrderItemsListBox.Items.Add(item.Name);
                AmountSelectedOrderLabel.Text = _currentPriorityOrder.Amount.ToString("F2"); // ИСПРАВЛЕНО: AmountOrder → Amount
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении товара: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = OrderItemsListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Выберите товар для удаления.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _currentPriorityOrder.Items.RemoveAt(index);
                OrderItemsListBox.Items.RemoveAt(index);
                AmountSelectedOrderLabel.Text = _currentPriorityOrder.Amount.ToString("F2"); // ИСПРАВЛЕНО: AmountOrder → Amount
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении товара: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите очистить заказ?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CreateNewPriorityOrder();
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            CreateNewPriorityOrder();
        }
    }
}