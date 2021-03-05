using System;

namespace interfaceTest1
{
    public class GoldenClient : BaseClient, IClient
    {

        public void Buy(int ProductID)
        {

            Console.WriteLine("Golden user is buying an Item");
        }

        public decimal Getdiscount(decimal totalCost)
        {
            decimal finalPrice = totalCost * 0.7M;
            Console.WriteLine($"Discounted price is : {finalPrice:C2}");
            return finalPrice;
        }
    }
}