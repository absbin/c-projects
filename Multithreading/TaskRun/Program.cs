using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task.Run(() => { Thread.Sleep(2000); Console.WriteLine("I am here!"); });
            Task.Run(DoActions);
            Task.Run(DoActions);
            Task.Run(DoActions);
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
