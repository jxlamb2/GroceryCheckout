using System;
using System.Collections.Generic;
using System.Text;
using Cart.Interfaces;
using CheckoutCalculator.Interfaces;
using GroceryItems.Factory;
using GroceryItems.Item;

namespace Cart.Cart
{
    public class ShoppingCart : IShoppingCart
    {
        #region Private Variables

        private readonly List<GroceryItem> _groceryItems;

        private readonly IGroceryCalculator _groceryCalculator;

        #endregion

        #region Constructor

        public ShoppingCart(IGroceryCalculator groceryCalculator)
        {
            _groceryItems = new List<GroceryItem>();
            _groceryCalculator = groceryCalculator;
        }

        #endregion

        #region Public Methods

        #region ClearCart

        public void ClearCart()
        {
            _groceryItems.Clear();
        }

        #endregion

        #region AddItem

        public void AddItems(List<int> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items), "Items to add to shopping cart cannot be null.");
            }

            foreach (var itemId in items)
            {
                AddItem(itemId);
            }
        }

        public void AddItems(List<string> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items), "Items to add to shopping cart cannot be null.");
            }

            foreach (var itemName in items)
            {
                AddItem(itemName);
            }
        }

        public void AddItem(string itemName)
        {
            var item = GroceryItemFactory.CreateGroceryItem(itemName);
            AddItem(item);
        }

        public void AddItem(int itemId)
        {
            var item = GroceryItemFactory.CreateGroceryItem(itemId);
            AddItem(item);
        }

        public void AddItem(GroceryItem item)
        {
            _groceryItems.Add(item);
        }

        #endregion

        #region AddItemWithTotal

        public decimal AddItemsWithTotal(List<int> items)
        {
            AddItems(items);
            return _groceryCalculator.GetTotal(_groceryItems);
        }

        public decimal AddItemsWithTotal(List<string> items)
        {
            AddItems(items);
            return _groceryCalculator.GetTotal(_groceryItems);
        }

        public decimal AddItemWithTotal(string itemName)
        {
            AddItem(itemName);
            return _groceryCalculator.GetTotal(_groceryItems);
        }

        public decimal AddItemWithTotal(int itemId)
        {
            AddItem(itemId);
            return _groceryCalculator.GetTotal(_groceryItems);
        }

        public decimal AddItemWithTotal(GroceryItem item)
        {
            _groceryItems.Add(item);
            return _groceryCalculator.GetTotal(_groceryItems);
        }

        #endregion

        #region GetTotal

        public decimal GetCartTotal()
        {
            return _groceryCalculator.GetTotal(_groceryItems);
        }

        #endregion

        #region DisplayItems

        public string DisplayCartItems()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Items in shopping cart:");

            foreach (var item in _groceryItems)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }

        public List<GroceryItem> GetCartItems()
        {
            return _groceryItems;
        }

        #endregion

        #endregion

    }
}
