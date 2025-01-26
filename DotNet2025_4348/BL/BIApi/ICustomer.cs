using BO;

namespace BIApi
{
    public interface ICustomer
    {
        public void addCustomer(Customer customer);
        public void removeCustomer(int identity);
        public void updateCustomer(Customer customer);
    }
}
