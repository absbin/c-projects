using System;

namespace interfacesTest
{
    public class Student : IPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Field { get; set; }
        public string Role { get; set; }

        public bool AskForCourse(Course cs)
        {
            if (cs.StudentCount < 100)
            {
                return true;
            }

            else { return false; }
        }

        public void PrintRole()
        {
            Console.WriteLine($"I am a {Role}");
        }
    }
}