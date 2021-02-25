using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n Please enter an index: ");
            int idx = Convert.ToInt32(Console.ReadLine());
            int result = ExceptionManager.GetNumber(idx);

            if (ExceptionManager.wrongAnswer == true)
            {
                Console.WriteLine("There was a Problem!");
            }
            else
            {
                Console.WriteLine($"the number is {result}");
            }
            Console.ReadLine();
        }
    }
}