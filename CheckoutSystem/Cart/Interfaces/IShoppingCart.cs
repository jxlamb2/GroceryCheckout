using System.Collections.Generic;
using GroceryItems.Item;

namespace Cart.Interfaces
{
    public interface IShoppingCart
    {
        void AddItem(GroceryItem item);

        void ClearCart();

        decimal GetCartTotal();

        void AddItems(List<int> items);

        void AddItems(List<string> items);

        void AddItem(string itemName);

        void AddItem(int itemId);

        string DisplayCartItems();

        List<GroceryItem> GetCartItems();
    }
}