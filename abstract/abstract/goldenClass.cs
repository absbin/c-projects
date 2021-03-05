using System;

namespace interfaceTest1
{
    public class GoldenClient : Client
    {
        public override int MyProperty { get; set; }
        // public new void Register(string name)
        public override void Register(string name)
        {
            Console.WriteLine($"Golden Client {name} is registered successsfully");
        }
        public override void Buy(int ProductID)
        {

            Console.WriteLine("Golden user is buying an Item");
        }

        public override decimal Getdiscount(decimal totalCost)
        {
            decimal finalPrice = totalCost * 0.7M;
            Console.WriteLine($"Discounted price is : {finalPrice:C2}");
            return finalPrice;
        }
    }
}