using System;

namespace class_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager mng=new Manager();
            mng.Name="Alex";
            
            Client cl1=mng.AddClient("Sara");
            cl1.Buy("Book1");
            Console.WriteLine("New Cient is "+cl1.Name);
            Console.WriteLine(cl1.GetPoints());
            cl1.Buy("Book2");
            Console.WriteLine(cl1.GetPoints());

            Client cl2=mng.AddClient("Saeed");
            Console.WriteLine("New Cient is "+cl2.Name);
            Console.WriteLine(cl2.GetPoints());
            cl2.Buy("Socks1");
            Console.WriteLine(cl2.GetPoints());
        }
    }

    public class Client
    {
        public string Name;
        private int point=0;

        public int GetPoints()
        {
            return point;
        }        
        
        public void Buy(string propduct)
        {
            // Buy the product
            point++;            
        }
    }    

    public class Manager
    {
        public string Name;
        public Client AddClient( string clientName )
        {
            Client client1=new Client();
            client1.Name=clientName;
            return client1;
        }

    }

}
