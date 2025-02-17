using BO;

namespace BIApi
{
    public interface ICustomer
    {
        public void addCustomer(BO.Customer customer);
        public void removeCustomer(int identity);
        public void updateCustomer(BO.Customer customer);
        public Customer GetCustomer(int id);
        public List<Customer> GetCustomers();
    }
}
