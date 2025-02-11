using BIApi;
using BO;

namespace BIImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addProduct(BO.Order order, ProductOrder productOrder)
        {
            order.Products.Add(productOrder);
        }

        public double orderTermination(Order order)
        {
            double sum = 0;
            foreach (ProductOrder p in order.Products)
            {
                sum += BO.Tools.priceProduct(p,order.IsClub);
            }
            return sum;
        }
    }
}
