using DalApi;

namespace Dal
{
    public class DalList : IDal
    {
        //מה המשמעות של החץ?
        public ICustomer Customer => new CustomerImplementation();
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplemention();
    }
}


