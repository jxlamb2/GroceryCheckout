using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckoutCalculator.Interfaces;
using GroceryItems.Item;

namespace CheckoutCalculator.SaleRules.Rules
{
    public class BuyOneGetOne : ISaleRule
    {
        private readonly HashSet<int> _bogoItems = new HashSet<int>{1,3};

        public decimal DetermineRuleDiscount(List<GroceryItem> items, decimal currentTotal)
        {
            var bogoGroceryItems = items.Where(t => _bogoItems.Contains(t.ItemId));
            var orderedBogoGroceryItems = bogoGroceryItems.OrderByDescending(t => t.ItemPrice);

            bool isEven = false;

            decimal discount = 0;

            foreach (var item in orderedBogoGroceryItems)
            {
                if (isEven)
                {
                    discount = discount + item.ItemPrice;
                }

                //every other iteration
                isEven = isEven == false;
            }

            return discount;
        }
    }
}
