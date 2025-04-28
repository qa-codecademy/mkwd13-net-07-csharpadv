using Abstractions.Entities.BaseEntity;
using Abstractions.Entities.Interfaces;

namespace Abstractions.Entities.Models
{
    public class DevOps : Human, IDevOps
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

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int>() { 200, 202, 204 };
            if (okStatuses.Contains(status))
            {
                return true;
            }
            return false;
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("Open StackEchange DevOps...");
            Console.WriteLine("tak tak tak tak tak...");
        }
    }
}
