using DalApi;

namespace Dal;

public class DalList : IDal
{
    public ICustomer Customer => new CustomerImplementation();
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplemention();
}




