namespace BIApi
{
    public interface IGiveObjects
    {
        public List<BO.Product> GetProducts();
        public List<BO.Product> GetMissingProduct();
    }
}
