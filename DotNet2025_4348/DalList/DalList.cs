using DalApi;

namespace Dal;

internal sealed class DalList : IDal
{
    private DalList()
    {
    }
    public static DalList Instance { get; } = new DalList();
    public ICustomer Customer => new CustomerImplementation();
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplemention();
}




