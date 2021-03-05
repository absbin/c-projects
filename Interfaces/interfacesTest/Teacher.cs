using System;

namespace interfacesTest
{
    public class Teacher : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Course Course { get; set; }

        public int Experience { get; set; }
        public string Role { get; set; }

        public double GetSalary()
        {
            return SalaryInfo.SalaryBase + (Experience * SalaryInfo.ExperienceBonus);
        }

        public void PrintRole()
        {
            Console.WriteLine($"I am a {Role}");
        }
    }
}