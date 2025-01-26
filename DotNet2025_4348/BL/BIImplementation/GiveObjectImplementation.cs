using BIApi;

namespace BO
{
    internal class GiveObjectImplementation : IGiveObjects
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<BO.Product> GetMissingProduct()
        {
            IEnumerable<DO.Product> ps =
                from product in _dal.Product.ReadAll()
                where product.QuantityInStock == 0
                select product;
            return ps.Select(p => Tools.toBOProduct(p)).ToList();
        }

        public List<Product> GetProducts()
        {
            return _dal.Product.ReadAll().Select(p=>Tools.toBOProduct(p)).ToList();
        }
    }
}
