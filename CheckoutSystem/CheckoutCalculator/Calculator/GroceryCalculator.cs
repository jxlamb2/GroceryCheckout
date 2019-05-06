using System.Collections.Generic;
using CheckoutCalculator.Interfaces;
using GroceryItems.Item;

namespace CheckoutCalculator.Calculator
{
    public class GroceryCalculator : IGroceryCalculator
    {
        #region Private Fields

        private readonly ISaleRule[] _rules;

        #endregion

        #region Constructors

        public GroceryCalculator(params ISaleRule[] rules)
        {
            _rules = rules;
        }

        #endregion

        #region Public Methods

        public decimal GetTotal(List<GroceryItem> groceryItems)
        {
            decimal total = 0;

            foreach (var item in groceryItems)
            {
                total = total + item.ItemPrice;
            }

            foreach (var rule in _rules)
            {
                var discount = rule.DetermineRuleDiscount(groceryItems, total);
                total = total - discount;
            }

            return total;
        }

        #endregion
    }
}