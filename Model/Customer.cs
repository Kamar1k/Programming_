using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный номер покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Общее количество предметов.
        /// </summary>
        private static int _IDCount;

        /// <summary>
        /// ФИО покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина товаров покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Приоритетный покупатель.
        /// </summary>
        private bool _isPriority;

        /// <summary>
        /// Список скидок покупателя.
        /// </summary>
        private List<IDiscount> _discounts;

        /// <summary>
        /// Свойство поля _id
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает значение, указывающее является ли покупатель приоритетным.
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        /// <summary>
        /// Свойство поля _fullname
        /// </summary>
        public string FullName
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnlengs(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Свойство поля _address
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров покупателя.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задает список скидок покупателя.
        /// </summary>
        public List<IDiscount> Discounts
        {
            get { return _discounts; }
            set { _discounts = value; }
        }

        /// <summary>
        /// Конструктор класса Customer
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес покупателя</param>
        /// <param name="isPriority">Является ли покупатель приоритетным</param>
        public Customer(string fullname, Address address, bool isPriority = false)
        {
            _IDCount++;
            _id = _IDCount;
            FullName = fullname;
            Address = address;
            IsPriority = isPriority;
            _cart = new Cart();
            _orders = new List<Order>();
            _discounts = new List<IDiscount>();

            // Автоматически добавляем накопительную скидку
            _discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Конструктор класса Customer
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        public Customer(string fullname)
        {
            _IDCount++;
            _id = _IDCount;
            FullName = fullname;
            Address = new Address();
            IsPriority = false;
            _cart = new Cart();
            _orders = new List<Order>();
            _discounts = new List<IDiscount>();

            // Автоматически добавляем накопительную скидку
            _discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Добавляет процентную скидку на указанную категорию товаров.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        public void AddPercentDiscount(Category category)
        {
            _discounts.Add(new PercentDiscount(category));
        }

        /// <summary>
        /// Удаляет скидку по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс скидки в списке.</param>
        /// <returns>True, если скидка удалена успешно, иначе False.</returns>
        public bool RemoveDiscount(int index)
        {
            if (index < 0 || index >= _discounts.Count)
                return false;

            // Нельзя удалить накопительную скидку (PointsDiscount)
            if (_discounts[index] is PointsDiscount)
                return false;

            _discounts.RemoveAt(index);
            return true;
        }
    }
}