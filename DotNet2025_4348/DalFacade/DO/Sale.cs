using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale
    {
        int Id { get; }
        int Barcode { get; }
        int AmountGetSale {  get; }
        double TotalPrice { get; }
        bool IntendedAllCustomers { get; } 
        DateTime StartSale {  get; }
        DateTime FinishSale { get; }

        public Sale(int id,int barcode, int amountGetSale,double totalPrice,bool intendedAllCustomers,DateTime startSale,DateTime finishSale)
        {
            this.Id = id;
            this.Barcode = barcode;
            this.AmountGetSale = amountGetSale;
            this.TotalPrice = totalPrice;
            this.IntendedAllCustomers = intendedAllCustomers;
            this.StartSale = startSale;
            this.FinishSale = finishSale;
        }
        public Sale()
        {
            
        }
    }
}
