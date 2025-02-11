using BIApi;
using BO;

namespace BIImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void addSale(BO.Sale sale)
        {
            DO.Sale s= BO.Tools.toDOSale(sale);
            _dal.Sale.Create(s);
        }

        public List<BO.Sale> getAllSale()
        {
           return _dal.Sale.ReadAll().Select(sale => BO.Tools.toBOSale(sale)).ToList();
        }

        public BO.Sale getSale(int id)
        {
            return BO.Tools.toBOSale(_dal.Sale.Read(id));
        }

        public void removeSale(int id)
        {
            _dal.Sale.Delete(id);
        }

        public void updateSale(Sale sale)
        {
            DO.Sale s = BO.Tools.toDOSale(sale);
            _dal.Sale.Update(s);
        }
    }
}
