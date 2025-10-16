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
        /// Свойство поля _id
        /// </summary>
        public int ID
        {
            get { return _id; }
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
        /// Консруктор класса Customer
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес доставки для покупателя</param>
        public Customer(string fullname, Address address)
        {
            _IDCount++;
            _id = _IDCount;
            _fullname = fullname;
            _address = address;
        }
    }
}
