using System;
using System.Collections.Generic;
using System.Text;
using CheckoutCalculator.Interfaces;
using GroceryItems.Item;

namespace CheckoutCalculator.SaleRules.Rules
{
    public class BuyTwoGetOneSame : ISaleRule
    {
        private readonly Dictionary<int,int> _discountEligibleItems = new Dictionary<int, int>();

        public decimal DetermineRuleDiscount(List<GroceryItem> items, decimal currentTotal)
        {
            _discountEligibleItems.Clear();
            _discountEligibleItems.Add(2, 0);//orange
            _discountEligibleItems.Add(4, 0);//melon

            var discount = 0m;
            foreach (var item in items)
            {
                if (_discountEligibleItems.ContainsKey(item.ItemId))
                {
                    _discountEligibleItems[item.ItemId]++;

                    if (_discountEligibleItems[item.ItemId] == 3)
                    {
                        discount = discount + item.ItemPrice;
                        _discountEligibleItems[item.ItemId] = 0;
                    }
                }

            }
            return discount;
        }
    }
}