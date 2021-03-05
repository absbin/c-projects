using System;
using System.Collections.Generic;

namespace interfacesTest
{


    public class Course : ICourse
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public int Credit { get; set; }

        public int StudentCount { get; set; }

        public List<Student> Students { get; private set; } = new List<Student>();

        public void AddStudent(Student st)
        {
            Students.Add(st);
            StudentCount++;
            Console.WriteLine($"Student {st.Name} was successfully added");
        }







    }
}