using System;
namespace AccessModifier
{
    public class AMClass2
    {             
        public AMClass2()
        {
            Console.WriteLine("********************"); 
        }
         
        // AMClass1 test=new AMClass1(); //before construtore is done!
        // void accessTest() // is not accessibble because its private
        public void accessTest()
        {            
            AMClass1 test=new AMClass1();
            // Console.WriteLine("Hello World!"+test.privateVar); //private variable  gives error
            Console.WriteLine("we are in AMClass2 PublicVar is : "+test.PublicVar); 
        }
    }
}