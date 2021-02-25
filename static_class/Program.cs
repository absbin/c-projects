using System;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("My static variable is "+MyStaticClass.MyStaticVariable);
            MyStaticClass.MyStaticMethod();
        }
    }
    
    public static  class MyStaticClass
    {
        public static void MyStaticMethod()
        {
            MyStaticVariable++;
            Console.WriteLine("My static variable is "+MyStaticVariable);
        }
        public static int MyStaticVariable=0;
    }
}
