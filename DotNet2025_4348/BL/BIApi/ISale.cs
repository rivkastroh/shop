namespace BIApi
{
    public interface ISale
    {
        public void addSale(BO.Sale sale);
        public void removeSale(int id);
        public void updateSale(BO.Sale sale);
        public List<BO.Sale> getAllSale();
        public BO.Sale getSale(int id);
    }
}
