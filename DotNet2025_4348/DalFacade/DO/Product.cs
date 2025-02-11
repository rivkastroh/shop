namespace DO
{

    //מסמל מוצר בחנות
    public record Product(
    int Barcode,
    string Name ,
    Categorys Category,
    double Price,
    int QuantityInStock
    )
    {

        public Product() : this(0,"",0,0,0)
        {
            
        }

    }
}
