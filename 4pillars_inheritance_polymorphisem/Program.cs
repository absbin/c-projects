using System;

namespace _4pillars_inheritance_polymorphisem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Hello World!***\n\n\nWe are in main func  Program class  ");
            Console.WriteLine(Book.BookShop);           
            PdfBook book1= new PdfBook("Animal Farm","George Orwell");
            book1.Price=21.5;
            book1.GetInfo();
            AudioBook book2= new AudioBook("AudioBook","Second author","Shakibaee");
            book2.GetInfo();
            book2.GetInfo(book2.Narrator);
            Book.Info();
            // BookShop="BookShopProgram_Modified"
            // Console.WriteLine(Book.MystaticVariable);
        }
    }

    public class Book
    {
        public static string BookShop="BookShopProgram";
        public static int MyStaticVariable=0;
        public string Name;
        public string Author;
        public static void Info()
        {
            Console.WriteLine("Static Info func In the Book class");
        }
        public Book()//constructor
        {
            Console.WriteLine("************In the Book class **************");
            MyStaticVariable++;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine(Name+ " : " + Author+MyStaticVariable);     
        }
    }
    public class PdfBook:Book    
    {
        public double Price;
        public PdfBook(string name,string author)
        {
            Name=name;
            Author=author;
        }
        public override void GetInfo()
        {
            Console.WriteLine("GetInfo() func in PdfBook class >>> "
            +Name+ " :\" Author is " + Author
            +". Price = "+Price+"$");
        }
    }
    public class AudioBook:Book
    {
        public string Narrator;
        public AudioBook(string name,string author,string narrator)
        {
            Name=name;
            Author=author;            
            Narrator=narrator;
        }       
        public  void GetInfo(string Narrator) //overloading
        {
            Console.WriteLine("*****\r\n\n"+Name+ " :\" Author is " + Author
            +" Narrator = "+Narrator);
        }
    }
}
