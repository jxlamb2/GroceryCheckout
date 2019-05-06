using System.Collections.Generic;
using GroceryItems.Item;

namespace CheckoutCalculator.Interfaces
{
    public interface IGroceryCalculator
    {
        decimal GetTotal(List<GroceryItem> groceryItems);
    }
}