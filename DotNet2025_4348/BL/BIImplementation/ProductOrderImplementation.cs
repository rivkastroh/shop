using BIApi;
using BO;

namespace BIImplementation
{
    internal class ProductOrderImplementation : IProductOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addAmount(int amount,ProductOrder productOrder)
        {
            productOrder.Amount += amount;
        }
    }
}
