using System;
using System.Collections.Generic;
using System.Linq;

namespace delegates1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IUsers normalUser = new NormalUser() { Name = "Martin" };
            IUsers goldenUser = new GoldenUser() { Name = "Reza" };
            normalUser.ShoppingCart = fillShoppingCart();
            goldenUser.ShoppingCart = fillShoppingCart();
            decimal normalUserFinalPrice = normalUser.ShoppingCart.GetFinalPrice(ComputeTotal, normalUser.GetDiscountedPrice);
            decimal goldenUserFinalPrice = goldenUser.ShoppingCart.GetFinalPrice(ComputeTotal, goldenUser.GetDiscountedPrice);
            Console.WriteLine($"Normal User {normalUserFinalPrice} \n");
            Console.WriteLine($"Golden User {goldenUserFinalPrice} \n");

        }
        private static decimal ComputeTotal(List<ProductModel> items)
        {
            return items.Sum(x => x.Price);

        }
        private static ShoppingCartModel fillShoppingCart()
        {
            ShoppingCartModel cart = new ShoppingCartModel();
            cart.Items.Add(new ProductModel() { Name = "Tsgirt1", Price = 10.5M });
            cart.Items.Add(new ProductModel() { Name = "Tsgirt2", Price = 11.5M });
            cart.Items.Add(new ProductModel() { Name = "Pants1", Price = 12.5M });
            cart.Items.Add(new ProductModel() { Name = "Pants2", Price = 13.5M });
            return cart;

        }

    }
}