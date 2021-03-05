using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoActions();
            DoActions();
            DoActions();
            DoActions();
            

            Console.WriteLine("Done!");

        }

        private static void DoActions()
        {
            Thread.Sleep(2000);
            Console.WriteLine("I am here!");
        }
    }
}
