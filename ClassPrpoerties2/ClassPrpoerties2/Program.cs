using System;

namespace ClassPrpoerties2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel car1 = new CarModel("Pride", "Saipa", "Brown");
            CarModel car2 = new CarModel("Benz", "Mercedes", "White");
            Console.WriteLine("Hello World! \n" + car1.Color);
            Console.WriteLine(car2.Color);
            // Color2 = "Orange";
            // Console.WriteLine(Color2);
        }
    }
}
