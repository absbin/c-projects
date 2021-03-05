using System;
using System.Collections.Generic;
using System.Linq;

namespace delegates1
{
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public delegate decimal ComputeDiscountedPrice(decimal totalPrice);
        // public delegate void PrinteDiscountValue(decimal totalPrice, decimal finalPrice);
        public decimal GetFinalPrice(Func<List<ProductModel>, decimal> culculateTotal,
        ComputeDiscountedPrice discountedPriceCalculator,
        Action<decimal, decimal> printeDiscountValue)
        {
            decimal total = culculateTotal(Items);
            decimal dicountedValue = discountedPriceCalculator(total);

            printeDiscountValue(total, dicountedValue);
            return dicountedValue;

        }

    }
}