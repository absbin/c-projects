namespace delegates1
{
    public class GoldenUser : IUsers
    {
        public string Name { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; }

        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            return totalPrice * (1 - 0.30M);
        }
    }
}