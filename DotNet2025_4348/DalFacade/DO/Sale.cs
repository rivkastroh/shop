using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(
    int Id,
    int Barcode,
    int AmountGetSale,
    double TotalPrice,
    bool IntendedAllCustomers,
    DateTime StartSale,
    DateTime FinishSale
    )
    {
        public Sale(): this(0, 0, 0, 0,false,new DateTime(), new DateTime())
        {
            
        }
    }
}
