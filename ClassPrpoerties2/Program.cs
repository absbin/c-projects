using System;

namespace ClassPrpoerties2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel car1 = new CarModel("Pride", "Saipa", "Brown");
            CarModel car2 = new CarModel("Benz", "Mercedes", "White");
            Console.WriteLine("Hello World! Here is car 1\n" + car1.Color);
            Console.WriteLine("Hello World! Here is car 2\n" + car1.Color);
            Console.WriteLine(car2.Color);
            // Color2 = "Orange";
            Color3 = "RED";
            Console.WriteLine(Color3);


        }
        public static string Color3 { get; set; } //auto property

    }
}
