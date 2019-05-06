using System.Collections.Generic;
using GroceryItems.Item;

namespace CheckoutCalculator.Interfaces
{
    public interface ISaleRule
    {
        decimal DetermineRuleDiscount(List<GroceryItem> items, decimal currentTotal);
    }
}