using BIApi;
using BO;

namespace BIImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addSale(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void removeSale(int id)
        {
            throw new NotImplementedException();
        }

        public void updateSale(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
