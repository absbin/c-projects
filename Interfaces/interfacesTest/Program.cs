using System;
using System.Collections.Generic;

namespace interfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // IPerson p1;
            // p1=new Teacher();
            // p1=new Student();
            List<IPerson> people = new List<IPerson>();

            Console.WriteLine("Hello World!");
            Teacher teacher1 = new Teacher() { Name = "John", Role = "Teacher", Age = 40, Experience = 10 };
            Teacher teacher2 = new Teacher() { Name = "Abbas", Role = "Teacher", Age = 36, Experience = 16 };

            Course math = new Course() { Name = "Mathemtic", Teacher = teacher1, Credit = 3, StudentCount = 0 };
            Course programming = new Course() { Name = "programming", Teacher = teacher2, Credit = 5, StudentCount = 0 };

            Student st1 = new Student() { Name = "Tamanna", Role = "Student", Age = 18, Field = "Medicine" };
            Student st2 = new Student() { Name = "Taha", Role = "student", Age = 16, Field = "Aerospace" };

            double salary = teacher1.GetSalary();
            Console.WriteLine($"{teacher1.Name} salary is {salary}");

            if (math.StudentCount < 100)
            {
                math.AddStudent(st1);
            }
            if (math.StudentCount < 100)
            {
                math.AddStudent(st2);
            }
            teacher1.PrintRole();
            st1.PrintRole();

            Console.WriteLine("**********************");
            people.Add(teacher1);
            people.Add(teacher2);
            people.Add(st1);
            people.Add(st2);
            foreach (var item in people)
            {
                item.PrintRole();
                if (item is Teacher teach_name)// define teach_name for each item object
                {
                    Console.WriteLine($"The salary is {teach_name.GetSalary()}");
                }
            }





        }
    }
}

