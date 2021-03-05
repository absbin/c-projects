using System;

namespace interfaceTest1
{
    public class NormalClient : IClient
    {
        public void Register(string name)
        {
            Console.WriteLine($"Client {name} is registered successsfully");
        }
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