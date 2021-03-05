using System;

namespace interfaceTest1
{
    public class GoldenClient : IClient
    {
        public void Register(string name)
        {
            Console.WriteLine($"Client {name} is registered successsfully");
        }
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