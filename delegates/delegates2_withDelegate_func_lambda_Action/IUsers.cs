namespace delegates1
{
    public interface IUsers
    {
        string Name { get; set; }
        ShoppingCartModel ShoppingCart { get; set; }
        decimal GetDiscountedPrice(decimal totalPrice);


    }
}