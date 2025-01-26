using BO;

namespace BIApi
{
    public interface ISale
    {
        public void addSale(Sale sale);
        public void removeSale(int id);
        public void updateSale(Sale sale);
    }
}
