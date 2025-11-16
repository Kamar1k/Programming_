using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Текущий заказ.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                OrderStatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                if (_customers != null) UpdateOrders();
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет список заказов.
        /// </summary>
        private void UpdateOrders()
        {
            OrdersDataGridView.Rows.Clear();
            _orders.Clear();

            if (_customers == null) return;

            foreach (var customer in _customers)
            {
                if (customer.Orders == null) continue;

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);

                    string address = order.Address != null ?
                        $"{order.Address.Index}, {order.Address.City}, {order.Address.Street}" :
                        "Адрес не указан";

                    OrdersDataGridView.Rows.Add(
                        order.Id,
                        order.Date.ToShortDateString(),
                        order.Status,
                        customer.FullName,
                        address,
                        order.Amount.ToString("F2"));
                }
            }
        }

        /// <summary>
        /// Устанавливает данные выбранного заказа в элементы управления.
        /// </summary>
        private void SetOrderData()
        {
            if (_currentOrder == null) return;

            OrderIdTextBox.Text = _currentOrder.Id.ToString();
            OrderDateTextBox.Text = _currentOrder.Date.ToString();
            OrderStatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            OrderAddressControl.Address = _currentOrder.Address;
            AmountLabel.Text = _currentOrder.Amount.ToString("F2");

            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
            OrderStatusComboBox.Enabled = true;
        }

        /// <summary>
        /// Обработчик изменения выбранной строки в таблице заказов.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null) return;

            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index < 0 || index >= _orders.Count) return;

            _currentOrder = _orders[index];
            SetOrderData();
        }

        /// <summary>
        /// Обработчик изменения статуса заказа.
        /// </summary>
        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null || OrderStatusComboBox.SelectedIndex == -1) return;

            _currentOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedIndex;

            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index >= 0 && index < _orders.Count)
            {
                OrdersDataGridView.Rows[index].Cells[2].Value = _currentOrder.Status;
            }
        }
    }
}