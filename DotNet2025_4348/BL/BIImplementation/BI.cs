using BIApi;
using BO;

namespace BIImplementation
{
    internal class BI : IBI
    {
        public ICustomer customer => new CustomerImplemntion();

        public IGiveObjects giveObjects => new GiveObjectImplementation();

        public IOrder order => new OrderImplementation();

        public IProduct product => new ProductImplementation();

        public IProductOrder productOrder => new ProductOrderImplementation();

        public ISale sale => new SaleImplementation();
    }
}
