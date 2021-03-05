namespace delegates1
{
    public class NormalUser : IUsers
    {
        public string Name { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; } = new ShoppingCartModel();
        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            if (ShoppingCart.Items.Count > 5)
            {
                return totalPrice * (1 - 0.30M);
            }
            else
            {
                return totalPrice;
            }
        }
    }
}