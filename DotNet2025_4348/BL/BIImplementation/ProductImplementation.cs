using BIApi;
using BO;

namespace BIImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addAmount(int barcode, int amount)
        {//מוסיפה למוצר כמות במלאי
            BO.Product p = BO.Tools.toBOProduct(_dal.Product.Read(barcode));
            p.QuantityInStock += amount;
            this.updateProduct(p);
        }

        public void addProduct(BO.Product product)
        {
            DO.Product p = BO.Tools.toDOProduct(product);
            _dal.Product.Create(p);
        }

        public BO.Product GetProduct(int barcode)
        {
            return BO.Tools.toBOProduct(_dal.Product.Read(barcode));
        }

        public List<BO.Product> GetProducts()
        {
            return _dal.Product.ReadAll().Select(product => BO.Tools.toBOProduct(product)).ToList();
        }

        public bool OutStock(Product product)
        {//מחזירה האם מוצר חסר במלאי
            return product.QuantityInStock > 0;
        }

        public void removeProduct(int barcode)
        {
            _dal.Product.Delete(barcode);
        }

        public void updateProduct(Product product)
        {
            DO.Product p = BO.Tools.toDOProduct(product);
            _dal.Product.Update(p);
        }
    }
}
