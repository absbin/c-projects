using System.Collections.Generic;
using System.Linq;

namespace delegates1
{
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        public decimal GetFinalPrice()
        {
            return Items.Sum(x => x.Price);
        }

    }
}