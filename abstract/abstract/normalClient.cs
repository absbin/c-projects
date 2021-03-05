using System;

namespace interfaceTest1
{

    public class NormalClient : Client
    {
        public override int MyProperty { get; set; }
        public override void Buy(int ProductID)
        {

            Console.WriteLine("Normal user is buying an Item");
        }

        public override decimal Getdiscount(decimal totalCost)
        {
            decimal finalPrice = totalCost * 0.9M;
            Console.WriteLine($"Discounted priceis : {finalPrice:C2}");
            return finalPrice;
        }
    }
}