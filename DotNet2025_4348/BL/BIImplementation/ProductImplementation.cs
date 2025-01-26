using BIApi;
using BO;

namespace BIImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addAmount(Product product, int amount)
        {
            throw new NotImplementedException();
        }

        public void addProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool OutStock(Product product)
        {
            throw new NotImplementedException();
        }

        public void removeProduct(int barcode)
        {
            throw new NotImplementedException();
        }

        public void updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
