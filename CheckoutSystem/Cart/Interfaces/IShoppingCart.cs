using System.Collections.Generic;
using GroceryItems.Item;

namespace Cart.Interfaces
{
    public interface IShoppingCart
    {
        void ClearCart();

        decimal GetCartTotal();

        void AddItem(GroceryItem item);

        void AddItems(List<int> items);

        void AddItems(List<string> items);

        void AddItem(string itemName);

        void AddItem(int itemId);

        decimal AddItemWithTotal(GroceryItem item);

        decimal AddItemsWithTotal(List<int> items);

        decimal AddItemsWithTotal(List<string> items);

        decimal AddItemWithTotal(string itemName);

        decimal AddItemWithTotal(int itemId);

        string DisplayCartItems();

        List<GroceryItem> GetCartItems();
    }
}