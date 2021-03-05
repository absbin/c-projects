using System.Collections.Generic;

namespace interfacesTest
{
    public interface ICourse
    {
        string Name { get; set; }
        Teacher Teacher { get; set; }
        int Credit { get; set; }
        int StudentCount { get; set; }
        List<Student> Students { get; }

        void AddStudent(Student st);
    }
}

