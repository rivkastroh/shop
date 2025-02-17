namespace BO
{
    public class ProductOrder
    {
        public int Barcode { get; init; }
        public int Amount { get; set; }
        public double Price { get; init; }
        public List<Sale> SaleList { get; init; }
        public ProductOrder(int barcode)
        {
            this.Barcode = barcode;
            this.Price = Tools.priceProduct(barcode); ;
            this.Amount = 1;
            this.SaleList = Tools.salesProduct(this.Barcode);
        }
        public override string ToString()
        {
            return $"product in order:  barcode: {Barcode}  amount: {Amount}  price: {Price}  sale list:{Tools.toStringObject(SaleList)}";
        }
    }
}
