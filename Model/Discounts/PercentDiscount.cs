using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет реализацию по представлению процентной скидки.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        private double _purchaseAmount;
        private int _currentPercentDiscount = 1;

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }

        /// <summary>
        /// Возвращает информацию по скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {_currentPercentDiscount}%";
            }
        }

        /// <summary>
        /// Возвращает и задает категорию.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает сумму по категории.
        /// </summary>
        public double PurchaseAmount
        {
            get => _purchaseAmount;
            set => _purchaseAmount = value;
        }

        /// <summary>
        /// Возвращает и задает процентную скидку.
        /// </summary>
        public int CurrentPercentDiscount
        {
            get => _currentPercentDiscount;
            set => _currentPercentDiscount = value;
        }

        /// <summary>
        /// Высчитывает скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает сумму скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null) return 0;

            double amount = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }

            return amount * ((double)_currentPercentDiscount / 100);
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возвращает сумму со скидкой.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Высчитывает новый процент скидки.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            if (items == null) return;

            double amount = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }

            _purchaseAmount += amount;

            // ВАЖНОЕ ИСПРАВЛЕНИЕ: скидка = 1% + (каждые 1000 рублей)
            // Было: newDiscountPercent = (int)(PurchaseAmount / 1000)
            // Стало: newDiscountPercent = 1 + (int)(PurchaseAmount / 1000)
            _currentPercentDiscount = 1 + (int)(_purchaseAmount / 1000);

            // Ограничение максимум 10%
            if (_currentPercentDiscount > 10)
            {
                _currentPercentDiscount = 10;
            }
        }
    }
}
