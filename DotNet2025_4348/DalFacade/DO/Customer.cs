namespace DO
{
    public record Customer(
        int Identity,
        string Name,
        string Address,
        string PhoneNumber
    )
    {
        public Customer() : this(0, "", "", "")
        {

        }
    }
}
