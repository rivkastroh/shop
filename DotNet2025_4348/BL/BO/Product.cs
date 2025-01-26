using DO;

namespace BO
{
    public class Product
    {
        public int barcode { get; init; }
        public string Name { get; init; }
        public Categorys Category { get; init; }
        public double Price {  get; init; }
        public int QuantityInStock {  get; set; }
    }
}
