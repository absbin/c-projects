using System;

namespace interfaceTest1
{
    public class BaseClient
    {
        public void Register(string name)
        {
            Console.WriteLine($"Client {name} is registered successsfully");
        }
    }
}