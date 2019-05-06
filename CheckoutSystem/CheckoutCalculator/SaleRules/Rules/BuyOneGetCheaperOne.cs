using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CheckoutCalculator.Interfaces;
using GroceryItems.Item;

namespace CheckoutCalculator.SaleRules.Rules
{
    public class BuyOneGetCheaperOne : ISaleRule
    {
        private readonly HashSet<int> _bogoItems = new HashSet<int>{1,3};

        public decimal DetermineRuleDiscount(List<GroceryItem> items, decimal currentTotal)
        {
            var discountEligibleItems = new List<decimal>();
            var discount = 0m;
            foreach (var item in items)
            {
                if (_bogoItems.Contains(item.ItemId))
                {
                    discountEligibleItems.Add(item.ItemPrice);
                }
            }

            //discount cheapest items
            discountEligibleItems.Sort();
            int itemsToDiscount = discountEligibleItems.Count / 2;

            for (int i = 0; i < itemsToDiscount; i++)
            {
                discount = discount + discountEligibleItems[i];
            }
            return discount;
        }
    }
}
