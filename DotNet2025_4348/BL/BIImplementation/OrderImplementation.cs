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

        public void BuyProduct(Order order)
        {
            foreach (BO.ProductOrder p in order.Products) 
            {
                BO.Tools.BuyProduct(p);
            }
        }

        public BO.ProductOrder isExixt(Order order, int barcode)
        {
            foreach(BO.ProductOrder p in order.Products)
            {
                if(p.Barcode == barcode)
                    return p;
            }
            return null;
        }

        public double orderTermination(Order order)
        {
            double sum = 0;
            foreach (ProductOrder p in order.Products)
            {
                sum += BO.Tools.priceProduct(p,order.Customer != null);
            }
            return sum;
        }
    }
}
