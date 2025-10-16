using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс покупателя.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион покупателя.
        /// </summary>
        private string _country = null!;

        /// <summary>
        /// Город покупателя.
        /// </summary>
        private string _city = null!;

        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string _street = null!;

        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string _building = null!;

        /// <summary>
        /// Номер квартиры/помещения покупателя.
        /// </summary>
        private string _apartment = null!;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс покупателя.
        /// Должно находится в диапазоне от 100000 до 999999 (включительно).
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                AssertValueInRange(value, 100000, 999999, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион покупателя.
        /// Должно содержать до 50 символов (включительно).
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                AssertStringOnlengs(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт город (населенный пункт) покупателя.
        /// Должно содержать до 50 символов (включительно).
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                AssertStringOnlengs(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу покупателя.
        /// Должно содержать до 100 символов (включительно).
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                AssertStringOnlengs(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома покупателя.
        /// Должно содержать до 10 символов (включительно).
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                AssertStringOnlengs(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения покупателя.
        /// Должно содержать до 10 символов (включительно).
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                AssertStringOnlengs(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс покупателя.
        /// Должно находится в диапазоне от 100000 до 999999 (включительно).</param>
        /// <param name="country">Страна/регион покупателя.
        /// Должно содержать до 50 символов (включительно).</param>
        /// <param name="city">Город (населенный пункт) покупателя.
        /// Должно содержать до 50 символов (включительно).</param>
        /// <param name="street">Улица покупателя.
        /// Должно содержать до 100 символов (включительно).</param>
        /// <param name="building">Номер дома покупателя.
        /// Должно содержать до 10 символов (включительно).</param>
        /// <param name="apartment">Номер квартиры/помещения покупателя.
        /// Должно содержать до 10 символов (включительно).</param>
        public Address(int index, string country, string city,
                       string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "None";
            City = "None";
            Street = "None";
            Building = "None";
            Apartment = "None";
        }
    }
}
