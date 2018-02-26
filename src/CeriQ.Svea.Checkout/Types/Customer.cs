using System;

namespace CeriQ.Svea.Checkout.Types
{
    /// <summary>
    /// Information about the legal entity that's making the order.
    /// </summary>
    public sealed class Customer
    {
        /// <summary>
        /// Called Social Security Number in the USA, Personnummer or Organisationsnummer in Sweden.
        /// </summary>
        public string NationalId { get; }
        /// <summary>
        /// Flag for if this entity is a company or not
        /// </summary>
        public bool IsCompany { get; }
        /// <summary>
        /// True if the person is a male, false if a female, undefined if company.
        /// </summary>
        public bool IsMale { get; }
        /// <summary>
        /// Date of birth for this person. Undefined if company.
        /// </summary>
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
