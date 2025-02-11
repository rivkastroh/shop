namespace BIApi
{
    public interface IBI
    {
        BIApi.ICustomer customer { get; }
        IGiveObjects giveObjects { get; }
        BIApi.IOrder order { get; }
        BIApi.IProduct product { get; }
        BIApi.IProductOrder productOrder { get; }
        BIApi.ISale sale { get; }
    }
}
