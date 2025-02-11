using BO;

namespace BIApi
{
    public interface IProduct
    {
        public void addProduct(BO.Product product);
        public void removeProduct(int barcode);
        public void updateProduct(BO.Product product);
        public bool OutStock(BO.Product product);
        public void addAmount(int barcode,int amount);
        public List<BO.Product> GetProducts();
        public Product GetProduct(int barcode);
    }
}
