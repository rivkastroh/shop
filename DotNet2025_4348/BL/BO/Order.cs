namespace BO
{
    public class Order
    {
        public BO.Customer Customer { get; init; }
        public List<ProductOrder> Products { get; init; }
        public Order(BO.Customer customer)
        {
            this.Customer = customer;
            Products = new List<ProductOrder>();
        }
        public override string ToString()
        {
            return $"order-  customer: {Customer}  products: {Tools.toStringObject(Products)}";
        }
    }
}
