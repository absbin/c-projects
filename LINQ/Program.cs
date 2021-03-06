using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Student> students = new List<Student>() { };
            students.Add(new Student("a", 1, 50));
            students.Add(new Student("b", 2, 40));
            students.Add(new Student("c", 3, 30));
            students.Add(new Student("d", 4, 20));
            students.Add(new Student("e", 5, 10));

            // var result = students.OrderBy(x => x.Name).ToList();
            // var result = students.OrderBy(x => x.Donation).ToList();
            // var result = students.OrderByDescending(x => x.Donation).ToList();
            // var result = students.OrderBy(x => x.Name).ThenBy(x => x.Donation).ToList();
            // var result = students.Where(x => x.GPA > 3).ToList(); // filter
            var result = students.Where(x => x.GPA > 3 && x.Donation < 20).ToList();
            // var result = students.Select(x => x.Name).ToList();// ****Returns only names
            // var result = students.Where(x => x.GPA > 3).ToList();

            foreach (var st in result)
            {
                Console.WriteLine($"{st.Name}-{st.GPA}-{st.Donation}");
                // Console.WriteLine($"{st}");// ****Returns only names
            }
            var result2 = students.Sum(x => x.Donation);

            Console.WriteLine($"Donation Sum is {result2}");

        }

    }

}

