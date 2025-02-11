namespace BO
{
    public class Customer
    {
       public int Identity {  get; init; }
       public string Name { get; init; }
       public string Address {  get; init; }
       public string PhoneNumber {  get; init; }
        public override string ToString()
        {
            return $"customer:  id: {Identity}  name: {Name}  address: {Address}  phone-number: {PhoneNumber}";
        }
    }
}
