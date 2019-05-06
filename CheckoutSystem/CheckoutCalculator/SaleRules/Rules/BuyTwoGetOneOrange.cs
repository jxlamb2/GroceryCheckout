using System;
using System.Collections.Generic;
using System.Text;
using CheckoutCalculator.Interfaces;
using GroceryItems.Item;

namespace CheckoutCalculator.SaleRules.Rules
{
    public class BuyTwoGetOneOrange : ISaleRule
    {
        public decimal DetermineRuleDiscount(List<GroceryItem> items, decimal currentTotal)
        {
            var orangeCount = 0;
            var discount = 0m;
            foreach (var item in items)
            {
                if (item.ItemName == "Orange")
                {
                    orangeCount++;
                }

                if (orangeCount == 3)
                {
                    orangeCount = 0;
                    discount = discount + item.ItemPrice;
                }
            }
            return discount;
        }
    }
}