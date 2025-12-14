using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет реализацию процентной скидки на категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        private double _purchaseAmount;
        private int _currentPercentDiscount = 1;

        public PercentDiscount(Category category)
        {
            Category = category;
        }

        public Category Category { get; }

        public string Info =>
            $"Процентная «{Category}» - {_currentPercentDiscount}%";

        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0)
                return 0;

            double categoryAmount = items
                .Where(item => item.Category == Category)
                .Sum(item => item.Cost);

            return categoryAmount * _currentPercentDiscount / 100.0;
        }

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0)
                return;

            double categoryAmount = items
                .Where(item => item.Category == Category)
                .Sum(item => item.Cost);

            _purchaseAmount += categoryAmount;

            while (_purchaseAmount >= 1000 && _currentPercentDiscount < 10)
            {
                _currentPercentDiscount++;
                _purchaseAmount -= 1000;
            }
        }
    }
}
