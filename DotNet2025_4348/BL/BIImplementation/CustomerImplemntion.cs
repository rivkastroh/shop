using BIApi;

namespace BO
{
    internal class CustomerImplemntion : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addCustomer(BO.Customer customer)
        {
            DO.Customer DOCustomer = Tools.toDOCustomer(customer);
            _dal.Customer.Create(DOCustomer);
        }

        public void removeCustomer(int identity)
        {
            _dal.Customer.Delete(identity);
        }

        public void updateCustomer(Customer customer)
        {
            _dal.Customer.Update(Tools.toDOCustomer(customer));
        }
    }
}
