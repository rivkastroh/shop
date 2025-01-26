namespace BO
{
    public class Sale
    {
        public int Id { get; init; }
        public int Barcode { get; init; }
        public int AmountGetSale { get; init; }
        public double TotalPrice { get; init; }
        //צריך לבדוק מתי מתעדכן הורדת המחיר
        public double discount { get; init; }
        public bool IntendedAllCustomers { get; init; }
        public DateTime StartSale { get; init; }
        public DateTime FinishSale { get; init; }
    }
}
