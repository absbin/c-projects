using System.Collections.Generic;
using System.Linq;

namespace delegates1
{
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public delegate decimal ComputeDiscountedPrice(decimal totalPrice);
        public decimal GetFinalPrice(ComputeDiscountedPrice discountedPriceCalculator)
        {
            decimal total = Items.Sum(x => x.Price);
            return discountedPriceCalculator(total);
        }

    }
}