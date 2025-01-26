using BO;

namespace BIApi
{
    public interface IGiveObjects
    {
        public List<Product> GetProducts();
        public List<BO.Product> GetMissingProduct();
    }
}
