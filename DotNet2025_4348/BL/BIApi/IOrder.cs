using BO;

namespace BIApi
{
    public interface IOrder
    {
        public void addProduct(Order order,ProductOrder productOrder);
        public double orderTermination(Order order);
    }
}
