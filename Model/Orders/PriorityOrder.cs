using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Допустимые значения времени доставки.
        /// </summary>
        private static readonly string[] _validTimes =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() : base()
        {
            _desiredDeliveryDate = DateTime.Now;
            _deliveryTime = "9:00 - 11:00"; // Значение по умолчанию
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        public PriorityOrder(Address address, List<Item> items, DateTime desiredDeliveryDate, string deliveryTime)
            : base(address, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DeliveryTime = deliveryTime; // Валидация выполняется в свойстве
        }

        /// <summary>
        /// Возвращает и задает желаемую дату доставки. 
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get => _desiredDeliveryDate;
            set => _desiredDeliveryDate = value;
        }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get => _deliveryTime;
            set
            {
                if (value != null && Array.IndexOf(_validTimes, value) == -1)
                {
                    throw new ArgumentException("Недопустимое время доставки. " +
                        "Допустимые значения: 9:00-11:00, 11:00-13:00, 13:00-15:00, " +
                        "15:00-17:00, 17:00-19:00, 19:00-21:00");
                }

                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Возвращает массив допустимых значений времени доставки.
        /// </summary>
        public static string[] GetValidDeliveryTimes()
        {
            return (string[])_validTimes.Clone();
        }
    }
}