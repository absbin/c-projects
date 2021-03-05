using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            AMClass1 test1=new AMClass1();
            Console.WriteLine("Hello World!");
            // Console.WriteLine("Hello World! privateVar is : "+test1.privateVar); // Private var is not accessible
            Console.WriteLine("Hello World! PublicVar is : "+test1.PublicVar); 
            test1.accessTest();
            Console.WriteLine("Hello World! PublicVar is : "+test1.PublicVar);
            AMClass2 tset2=new AMClass2();
            tset2.accessTest();
            AMClass3 tset3=new AMClass3();
            tset3.accessTest3();


        }
    }
}
