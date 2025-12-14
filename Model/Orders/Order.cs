using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Сумма скидки.
        /// </summary>
        private double _discountAmount;

        /// <summary>
        /// Счетчик для генерации ID.
        /// </summary>
        private static int _idCounter = 1;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime Date => _date;

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задает список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает и задает сумму примененной скидки.
        /// </summary>
        public double DiscountAmount
        {
            get { return _discountAmount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Скидка не может быть отрицательной");
                _discountAmount = value;
            }
        }

        /// <summary>
        /// Возвращает общую стоимость заказа (без скидки).
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                    return 0.0;

                return _items.Sum(item => item.Cost);
            }
        }

        /// <summary>
        /// Возвращает итоговую стоимость заказа (со скидкой).
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items)
        {
            _id = _idCounter++;
            _date = DateTime.Now;
            _address = address;
            _items = new List<Item>(items);
            _status = OrderStatus.New;
            _discountAmount = 0.0;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = _idCounter++;
            _date = DateTime.Now;
            _address = new Address();
            _items = new List<Item>();
            _status = OrderStatus.New;
            _discountAmount = 0.0;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/> с указанием покупателя.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        public Order(Customer customer)
        {
            _id = _idCounter++;
            _date = DateTime.Now;
            _address = customer.Address;
            _items = new List<Item>();
            _status = OrderStatus.New;
            _discountAmount = 0.0;
        }
    }
}
