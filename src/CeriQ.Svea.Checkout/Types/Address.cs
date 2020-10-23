namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// An address to the customer, either for shipping or billing
    /// </summary>
    public sealed class Address
    {
        /// <summary>
        /// The full name of the recieving party.
        /// </summary>
        public string FullName { get; }
        /// <summary>
        /// First name of the recieving party.
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// Last name of the recieving party.
        /// </summary>
        public string LastName { get; }
        /// <summary>
        /// Street address including house number
        /// </summary>
        public string StreetAddress { get; }
        /// <summary>
        /// Care of for this address. May be null
        /// </summary>
        public string CoAddress { get; }
        /// <summary>
        /// Postal code for this address
        /// </summary>
        public string PostalCode { get; }
        /// <summary>
        /// City for this address
        /// </summary>
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
