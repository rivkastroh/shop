using BIApi;
using BO;

namespace BIImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addProduct(Order order, ProductOrder productOrder)
        {
            throw new NotImplementedException();
        }

        public double orderTermination(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
