using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        private int _points;

        public int Points
        {
            get => _points;
            private set => _points = value;
        }

        public string Info => $"Накопительная - {Points} баллов";

        public PointsDiscount()
        {
            _points = 0;
        }

        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0) return 0;

            double total = 0;
            foreach (var item in items)
            {
                total += item.Cost;
            }

            double maxDiscount = total * 0.3;
            return Math.Min(Points, maxDiscount);
        }

        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            double total = 0;
            foreach (var item in items)
            {
                total += item.Cost;
            }

            double maxDiscount = total * 0.3;

            if (Points <= maxDiscount)
            {
                Points = 0;
            }
            else
            {
                Points -= (int)maxDiscount;
            }

            return discount;
        }

        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0) return;

            double total = 0;
            foreach (var item in items)
            {
                total += item.Cost;
            }

            Points += (int)Math.Ceiling(total * 0.1);
        }
    }
}
