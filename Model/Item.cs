using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара
    /// </summary>
    public class Item
    {

        /// <summary>
        /// Уникальный номер товара
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Общее количество предметов.
        /// </summary>
        private static int _IDCount;

        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Свойство поля _id
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Свойство поля  _name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnlengs(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Свойство поля _info
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnlengs(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Свойство поля _cost
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }  // Тип должен быть Category, а не string

        /// <summary>
        /// Конструктор класса Item
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Описание товара</param>
        /// <param name="cost">Стоимость товара</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            _IDCount++;
            _id = _IDCount;
            _name = name;
            _info = info;
            _cost = cost;
            Category = category;
        }
    }
}
