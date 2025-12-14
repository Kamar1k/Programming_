using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
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
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

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

            // Инициализация ComboBox для времени доставки
            foreach (var time in _deliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }

            PriorityOptionsPanel.Visible = false;
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

                    // Добавляем звездочку для приоритетных заказов
                    string priorityMark = order is PriorityOrder ? "★" : "";

                    OrdersDataGridView.Rows.Add(
                        priorityMark,
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
            OrderStatusComboBox.SelectedItem = _currentOrder.Status;
            OrderAddressControl.Address = _currentOrder.Address;
            AmountLabel.Text = _currentOrder.Amount.ToString("F2");

            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
            OrderStatusComboBox.Enabled = true;

            // Обработка приоритетных заказов
            if (_currentOrder is PriorityOrder priorityOrder)
            {
                _currentPriorityOrder = priorityOrder;
                PriorityOptionsPanel.Visible = true;
                DeliveryTimeComboBox.SelectedItem = _currentPriorityOrder.DeliveryTime;
            }
            else
            {
                _currentPriorityOrder = null;
                PriorityOptionsPanel.Visible = false;
            }   
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
            if (_currentOrder == null || OrderStatusComboBox.SelectedItem == null) return;

            _currentOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedItem;

            // Обновляем отображение в таблице (учитываем новый столбец с звездочкой)
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index >= 0 && index < _orders.Count)
            {
                OrdersDataGridView.Rows[index].Cells[3].Value = _currentOrder.Status;
            }
        }

        /// <summary>
        /// Обработчик изменения времени доставки для приоритетных заказов.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder != null && DeliveryTimeComboBox.SelectedItem != null)
            {
                _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
            }
        }
    }
}