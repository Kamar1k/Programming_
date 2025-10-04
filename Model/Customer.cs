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
    internal class Customer
    {
        /// <summary>
        /// Уникальный номер покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки
        /// </summary>
        private string _address;

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
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnlengs(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Консруктор класса Customer
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес доставки для покупателя</param>
        public Customer(string fullname, string address)
        {
            _fullname = fullname;
            _address = address;
        }
    }
}
