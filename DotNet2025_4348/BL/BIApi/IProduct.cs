using BO;

namespace BIApi
{
    public interface IProduct
    {
        public void addProduct(Product product);
        public void removeProduct(int barcode);
        public void updateProduct(Product product);
        public bool OutStock(Product product);
        public void addAmount(Product product,int amount);
    }
}
