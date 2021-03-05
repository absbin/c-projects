namespace interfacesTest
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string Role { get; set; }

        void PrintRole();
    }
}