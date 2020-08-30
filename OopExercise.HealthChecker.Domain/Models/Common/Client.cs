using System;

namespace OopExercise.HealthChecker.Domain.Models.Common
{
    public class Client
    {
        public Client(string name, string emailAddress, string phoneNumber, string cellphoneNumber, string postalAddress)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            EmailAddress = emailAddress ?? throw new ArgumentNullException(nameof(emailAddress));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            CellphoneNumber = cellphoneNumber ?? throw new ArgumentNullException(nameof(cellphoneNumber));
            PostalAddress = postalAddress;
        }

        public string Name { get; private set; }
        public string EmailAddress { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CellphoneNumber { get; private set; }
        public string PostalAddress { get; private set; }
    }
}
