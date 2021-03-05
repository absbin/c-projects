namespace interfaceTest1
{
    public interface IClient
    {
        void Register(string name);
        void Buy(int ProductID);

        decimal Getdiscount(decimal totalCost);
    }
}