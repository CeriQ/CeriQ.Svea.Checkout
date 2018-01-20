namespace CeriQ.Svea.Checkout.Types
{
    public sealed class Address
    {
        public string FullName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string StreetAddress { get; }
        public string CoAddress { get; }
        public string PostalCode { get; }
        public string City { get; }

        public Address(string fullName, string firstName, string lastName, string streetAddress, string coAddress, string postalCode, string city)
        {
            FullName = fullName;
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            CoAddress = coAddress;
            PostalCode = postalCode;
            City = city;
        }
    }
}
