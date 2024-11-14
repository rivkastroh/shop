using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Customer
    {
        int Identity { get; }
        string Name { get; }
        string Address { get; }
        string PhoneNumber { get; }
        public Customer(int identity, string name, string address,string phoneNumber)
        {
            this.Identity = identity;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
        public Customer()
        {
            
        }
    }
}
