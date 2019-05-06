using System;
using System.Collections.Generic;
using Cart.Cart;
using CheckoutCalculator.Calculator;
using CheckoutCalculator.SaleRules.Rules;

namespace CheckoutSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cartCalculator = new GroceryCalculator(new BuyOneGetCheaperOne(), new BuyTwoGetOneSame());
            var shoppingCart = new ShoppingCart(cartCalculator);
            var itemsToAdd = new List<int>() { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4 };
            var total = shoppingCart.AddItemsWithTotal(itemsToAdd);
            Console.WriteLine($"Total: {total:C}");

            shoppingCart.AddItem(1);
            shoppingCart.AddItem(3);
            total = shoppingCart.AddItemWithTotal(4);
            Console.WriteLine($"Total: {total:C}");

            Console.WriteLine(shoppingCart.DisplayCartItems());
            Console.WriteLine($"Total: {shoppingCart.GetCartTotal():C}");
            Console.ReadLine();
        }
    }
}
