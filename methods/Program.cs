using System;
using System.Collections.Generic;
namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] movies = new string[3] {"Inception","Taken 1","Rain Man"};
            List<double> ranks =new List<double>();
            for (int i = 0; i < movies.Length; i++)
            {
                string text="Please insert your rsnks (1-10) for the movies: "+movies[i]+":";
                Console.WriteLine(text);                
                // ranks[i]=Convert.ToInt32(Console.ReadLine());
                int rank=Convert.ToInt32(Console.ReadLine());
                ranks.Add(rank) ;                 
            }  
            double average=CalculateAverage(ranks);
            Console.WriteLine("Average ranke score is : "+average );
            Console.ReadKey();
        }

        public static double CalculateAverage(List<double> userRanks)
        {
            double sum=0;
            for (var i = 0; i < userRanks.Count; i++)
            {
                sum+= userRanks[i];
            }            
            double avg= sum/userRanks.Count;
            return avg;
        }
    }
}
