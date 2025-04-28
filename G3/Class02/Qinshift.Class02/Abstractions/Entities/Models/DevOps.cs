using Abstractions.Entities.BaseEntity;

namespace Abstractions.Entities.Models
{
    public class DevOps : Human
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

        public DevOps(int id, string firstName, string lastName, int age, string phone, bool awsCert, bool azureCert) : base(id, firstName, lastName, age, phone)
        {
            AWSCertified = awsCert;
            AzureCertified = azureCert;
        }

        public override string GetInfo()
        {
            string result = $"{GetFullName()} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certificate" : "";
            result += AzureCertified ? " Azure Certificate" : "";
            result += AWSCertified || AzureCertified ? "" : "No certificates yet";
            return result;
        }

    }
}
