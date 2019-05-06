using System;
using System.Collections.Generic;
using System.Text;
using CheckoutCalculator.Interfaces;
using GroceryItems.Item;

namespace CheckoutCalculator.SaleRules.Rules
{
    public class BuyOneGetOneApple : ISaleRule
    {
        public decimal DetermineRuleDiscount(List<GroceryItem> items, decimal currentTotal)
        {
            var appleCount = 0;
            var discount = 0m;
            foreach (var item in items)
            {
                if (item.ItemName == "Apple")
                {
                    appleCount++;
                }

                if (appleCount == 2)
                {
                    appleCount = 0;
                    discount = discount + item.ItemPrice;
                }
            }
            return discount;
        }
    }
}