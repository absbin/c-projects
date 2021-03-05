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
            ThreadingActions();
            Console.WriteLine("Done2!");

            Console.ReadKey();

        }
        async static void ThreadingActions()
        {
             Task.Run(() => { Thread.Sleep(2000); Console.WriteLine("I am here in Lambda expression!"); });
             Task.Run(DoActions);
             Task.Run(DoActions);
            await Task.Run(DoActions);
            Console.WriteLine("Done1!");
            DoActions();
        }

        private static void DoActions()
        {
            Thread.Sleep(2000);
            Console.WriteLine("I am here!");
        }
    }
}
