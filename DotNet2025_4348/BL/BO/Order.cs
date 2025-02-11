namespace BO
{
    public class Order
    {
        public bool IsClub { get; init; }
        public List<ProductOrder> Products { get; init; }
        public Order(bool isClub)
        {
            this.IsClub = isClub;
            Products = new List<ProductOrder>();
        }
        public override string ToString()
        {
            return $"order-  club? {IsClub}  products: {Tools.toStringObject(Products)}";
        }
    }
}
