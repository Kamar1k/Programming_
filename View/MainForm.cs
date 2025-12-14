using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр магазина для хранения данных.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Передаем данные во все вкладки
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;

            // Добавляем обработчик переключения вкладок
            tab1Paget.SelectedIndexChanged += Tab1Paget_SelectedIndexChanged;

            priorityOrdersTab1.Items = _store.Items;
        }

        /// <summary>
        /// Обработчик события изменения выбранной вкладки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void Tab1Paget_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновляем CartsTab при переходе на нее
            if (tab1Paget.SelectedTab == Carts)
            {
                cartsTab1.RefreshData();
            }
            // Обновляем OrdersTab при переходе на нее
            else if (tab1Paget.SelectedIndex == 3) // Orders - индекс 3
            {
                ordersTab1.RefreshData();
            }
        }
    }
}