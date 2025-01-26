namespace BO
{
    public static class Tools
    {
        private static DalApi.IDal _dal = DalApi.Factory.Get;
        public static string ToStringProperty()
        {
            //יש לממש
            return null;
        }
        public static DO.Product toDOProduct(Product product)
        {
            //יש לממש
            return null;
        }
        public static BO.Product toBOProduct(DO.Product product)
        {
            //יש לממש
            return null;
        }
        public static DO.Sale toDOSale(Sale sale){
            //יש לממש
            return null;
        }
        public static BO.Sale toBOSale(DO.Sale sale)
        {
            //יש לממש
            return null;
        }
        public static DO.Customer toDOCustomer(Customer customer)
        {
            //יש לממש
            return null;
        }
        public static double priceProduct(ProductOrder productOrder, bool isClub)
        {//מחזירה מחיר כולל למוצר בהזמנה

            double sum = productOrder.Amount * productOrder.Price;
            //מעבר על רשימת המבצעים המתאימים והוזלה לפי מבצע מתאים
            if (!isClub)
            {
                IEnumerable<Sale> saleAllCustomer =
                    from sale in productOrder.SaleList
                    where sale.IntendedAllCustomers
                    select sale;
                foreach (Sale sale in saleAllCustomer)
                {
                    if (sale.AmountGetSale <= productOrder.Amount)
                        sum -= sale.discount;
                }
            }
            else
            {
                foreach (Sale sale in productOrder.SaleList)
                {
                    if (sale.AmountGetSale <= productOrder.Amount)
                        sum -= sale.discount;
                }
            }
            return sum;
        }
        public static List<Sale> salesProduct(int barcode)
        {
            //מחזירה רשימת מבצעים למוצר מסוים
            List<DO.Sale> l= _dal.Sale.ReadAll()
                .Where(s => s.Barcode == barcode).ToList();
            return l.Select(s=> toBOSale(s)).ToList();
        }
    }
}
