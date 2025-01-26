using BIApi;

namespace BIImplementation
{
    internal class ProductOrderImplementation : IProductOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addAmount(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
