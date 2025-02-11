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
        public static string toStringObject<T>(IEnumerable<T> objs)
        {
            string s = "";
            foreach (var obj in objs)
            {
                s += obj.ToString();
                s += ", ";
            }
            s.Substring(0, s.Length - 2);
            return s;
        }
        public static DO.Product toDOProduct(BO.Product productBO)
        {
            DO.Product p = new DO.Product()
            { Barcode = productBO.Barcode, Category = (DO.Categorys)productBO.Category, Name = productBO.Name, Price = productBO.Price, QuantityInStock = productBO.QuantityInStock };
            return p;
        }
        public static BO.Product toBOProduct(DO.Product productDO)
        {
            BO.Product p = new BO.Product()
            { Name = productDO.Name, Barcode = productDO.Barcode, Category = (BO.Categorys)productDO.Category, Price = productDO.Price, QuantityInStock = productDO.QuantityInStock };
            return p;
        }
        public static DO.Sale toDOSale(BO.Sale saleBO){
            DO.Sale s = new DO.Sale()
            { Id = saleBO.Id, Barcode = saleBO.Barcode, AmountGetSale = saleBO.AmountGetSale, IntendedAllCustomers = saleBO.IntendedAllCustomers, TotalPrice = saleBO.TotalPrice, StartSale = saleBO.StartSale, FinishSale = saleBO.FinishSale };
            return s;
        }
        public static BO.Sale toBOSale(DO.Sale saleDO)
        {
            double price = _dal.Product.Read(saleDO.Barcode).Price;
            BO.Sale s = new BO.Sale()
            { discount=price-saleDO.TotalPrice,Id = saleDO.Id, Barcode = saleDO.Barcode, StartSale = saleDO.StartSale, FinishSale = saleDO.FinishSale, TotalPrice = saleDO.TotalPrice, AmountGetSale = saleDO.AmountGetSale, IntendedAllCustomers = saleDO.IntendedAllCustomers };
            return s;
        }
        public static DO.Customer toDOCustomer(BO.Customer customerBO)
        {
            DO.Customer c = new DO.Customer()
            { Identity = customerBO.Identity, Name = customerBO.Name, Address = customerBO.Address, PhoneNumber = customerBO.PhoneNumber };
            return c;
        }
        public static BO.Customer toBOCustomer(DO.Customer customerDO)
        {
            BO.Customer c = new BO.Customer()
            { Identity = customerDO.Identity ,Name=customerDO.Name,Address=customerDO.Address,PhoneNumber=customerDO.PhoneNumber};
            return c;
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
