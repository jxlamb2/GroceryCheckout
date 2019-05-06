namespace GroceryItems.Item
{
    public class GroceryItem
    {
        #region Properties

        public int ItemId { get; }
        public string ItemName { get; }
        public decimal ItemPrice { get; }

        #endregion

        #region Constructors

        public GroceryItem(int itemId, string itemName, decimal itemPrice)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return $"ItemId: {ItemId}; ItemName: {ItemName}; Sale Price: {ItemPrice:C};";
        }

        #endregion
    }
}