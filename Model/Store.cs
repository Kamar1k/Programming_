﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин с товарами и покупателями.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров магазина.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает или задает список товаров магазина.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает или задает список покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
