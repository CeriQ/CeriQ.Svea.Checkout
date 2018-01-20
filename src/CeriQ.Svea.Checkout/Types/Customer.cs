using System;

namespace CeriQ.Svea.Checkout.Types
{
    public sealed class Customer
    {
        public string NationalId { get; }
        public bool IsCompany { get; }
        public bool IsMale { get; }
        public DateTime DateOfBirth { get; }

        public Customer(
            string nationalId,
            bool isCompany,
            bool isMale,
            DateTime dateOfBirth
            )
        {
            NationalId = nationalId;
            IsCompany = isCompany;
            IsMale = isMale;
            DateOfBirth = dateOfBirth;
        }
    }
}
