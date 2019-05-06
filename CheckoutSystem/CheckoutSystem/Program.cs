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
            var cartCalculator = new GroceryCalculator(new BuyOneGetOneApple(), new BuyTwoGetOneOrange());
            var shoppingCart = new ShoppingCart(cartCalculator);
            var itemsToAdd = new List<int>() { 1, 1, 1, 1, 2, 2, 2 };
            shoppingCart.AddItems(itemsToAdd);
            Console.WriteLine(shoppingCart.DisplayCartItems());
            Console.WriteLine($"Total: {shoppingCart.GetCartTotal():C}");
            Console.ReadLine();
        }
    }
}
