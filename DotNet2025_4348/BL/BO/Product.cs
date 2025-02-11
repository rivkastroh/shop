namespace BO
{
    public class Product
    {
        public int Barcode { get; init; }
        public string Name { get; init; }
        public BO.Categorys Category { get; init; }
        public double Price {  get; init; }
        public int QuantityInStock {  get; set; }

        public override string ToString()
        {
            return $"product-  barcode: {Barcode}  name: {Name}  category: {Category}  price: {Price}  quantity in stock: {QuantityInStock}";
        }
    }
}
