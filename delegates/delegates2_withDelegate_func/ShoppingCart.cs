using System;
using System.Collections.Generic;
using System.Linq;

namespace delegates1
{
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public delegate decimal ComputeDiscountedPrice(decimal totalPrice);
        public decimal GetFinalPrice(Func<List<ProductModel>, decimal> culculateTotal, ComputeDiscountedPrice discountedPriceCalculator)
        {
            decimal total = culculateTotal(Items);
            return discountedPriceCalculator(total);
        }

    }
}