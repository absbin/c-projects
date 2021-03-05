using System;
using System.Collections.Generic;

namespace interfaceTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Client> clients = new List<Client>() { new NormalClient(), new GoldenClient() };

            foreach (var item in clients)
            {
                item.Register("user1");
                item.Buy(10);
                item.Getdiscount(100);
                Console.WriteLine("-------------------------");
            }

        }
    }
}
