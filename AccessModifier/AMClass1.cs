using System;
namespace AccessModifier
{
    public class AMClass1
    {
        private int  privateVar=1;//only in this class
        public int  PublicVar=100;//only in this class
        protected int  protectedVar=50;//only in this class
        public AMClass1()
        {
            Console.WriteLine("In AMClass1 privateVar is : "+privateVar); // Private var is not accessible
        }
        // Console.WriteLine("In AMClass1 privateVar is : "+privateVar); // Private var is not accessible

    
        // void accessTest() // private
        public void accessTest() // private
        {
            privateVar=2;
            PublicVar=PublicVar+1;
            protectedVar=protectedVar+1;
            // Console.WriteLine("In AMClass1 privateVar is : "+privateVar); // Private var is not accessible
        }

    } 
}
