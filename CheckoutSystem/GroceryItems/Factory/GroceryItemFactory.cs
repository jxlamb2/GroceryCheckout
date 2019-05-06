using System;
using GroceryItems.Item;

namespace GroceryItems.Factory
{
    public static class GroceryItemFactory
    {
        private static GroceryItem GetApple()
        {
            return new GroceryItem(1, "Apple", .45m);
        }

        private static GroceryItem GetOrange()
        {
            return new GroceryItem(2, "Orange", .65m);
        }

        public static GroceryItem CreateGroceryItem(string itemName)
        {
            switch (itemName)
            {
                case "Apple":
                    return GetApple();
                case "Orange":
                    return GetOrange();
                default:
                    throw new ArgumentOutOfRangeException(nameof(itemName),
                        "Invalid string argument passed to CreateGroceryItem method.");
            }
        }

        public static GroceryItem CreateGroceryItem(int itemId)
        {
            switch (itemId)
            {
                case 1:
                    return GetApple();
                case 2:
                    return GetOrange();
                default:
                    throw new ArgumentOutOfRangeException(nameof(itemId),
                        "Invalid integer argument passed to CreateGroceryItem method.");
            }
        }
    }
}