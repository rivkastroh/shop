using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DO
{

    //מסמל מוצר בחנות
    public record Product
    {
        int Barcode {  get; }
        string Name { get; }
        Categorys Category { get; }
        double Price { get; }
        int QuantityInStock { get; }

        public Product()
        {
            
        }
        public Product(int barcode, string name, Categorys category,double price,int quantityInStock)
        {
            this.Barcode = barcode;
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.QuantityInStock = quantityInStock;
        }

    }
}
