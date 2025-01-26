namespace BO
{
    public class Order
    {
        public bool IsClub { get; init; }
        public List<Order> Orders { get; init; }
        public Order(bool isClub)
        {
            this.IsClub = isClub;
            Orders = new List<Order>();
        }
    }
}
