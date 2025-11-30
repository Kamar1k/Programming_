using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

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
        }
    }
    
}