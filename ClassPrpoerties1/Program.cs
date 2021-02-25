using System;

namespace ClassPrpoerties1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel car1 = new CarModel("Pride", "Saipa", "Brown");
            CarModel car2 = new CarModel("Benz", "Mercedes", "Black");
            Console.WriteLine("Hello World! \n" + car1.Color);
            Console.WriteLine(car2.Manufacturer);

        }
    }
}
