namespace LINQ
{
    public class Student
    {
        public string Name;
        public double GPA;
        public double Donation;

        public Student(string name, double avg, double donation)
        {
            Name = name;
            GPA = avg;
            Donation = donation;
        }
    }
}