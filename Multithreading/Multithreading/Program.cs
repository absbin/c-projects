using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread t1 = new Thread(DoActions);
            t1.Start();
            Thread t2 = new Thread(DoActions);
            t2.Start();
            Thread t3 = new Thread(DoActions);
            t3.Start();
            Thread t4 = new Thread(DoActions);
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            Console.WriteLine("Done!");

        }

        private static void DoActions()
        {
            Thread.Sleep(2000);
            Console.WriteLine("I am here!");
        }
    }
}
