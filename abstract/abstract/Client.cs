using System;

namespace interfaceTest1
{
    public abstract class Client
    {
        public int attribute1;
        public abstract int MyProperty { get; set; }

        // public void Register(string name)
        public virtual void Register(string name)
        {
            Console.WriteLine($"Client {name} is registered successsfully");
        }
        public abstract void Buy(int ProductID);

        public abstract decimal Getdiscount(decimal totalCost);
    }
}