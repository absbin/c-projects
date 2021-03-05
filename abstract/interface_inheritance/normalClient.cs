using System;

namespace interfaceTest1
{
    public class NormalClient : BaseClient, IClient
    {

        public void Buy(int ProductID)
        {

            Console.WriteLine("Normal user is buying an Item");
        }

        public decimal Getdiscount(decimal totalCost)
        {
            decimal finalPrice = totalCost * 0.9M;
            Console.WriteLine($"Discounted priceis : {finalPrice:C2}");
            return finalPrice;
        }
    }
}