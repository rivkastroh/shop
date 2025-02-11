namespace BO
{
    public class Sale
    {
        public int Id { get; init; }
        public int Barcode { get; init; }
        public int AmountGetSale { get; init; }
        public double TotalPrice { get; init; }
        public double discount { get; init; }
        public bool IntendedAllCustomers { get; init; }
        public DateTime StartSale { get; init; }
        public DateTime FinishSale { get; init; }
        public override string ToString()
        {
            return $"sale-  id: {Id}  barcode: {Barcode}  amount get sale: {AmountGetSale}  total price: {TotalPrice}  discount: {discount}  intended all customer?:{IntendedAllCustomers}  start sale: {StartSale}  finish sale: {FinishSale}";
        }
    }
}
