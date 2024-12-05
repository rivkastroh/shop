using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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
