using AbstractClassesAndInterfaces.Domain.Interfaces;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public class DevOpsEngineer : Person, IDevOpsEngineer, IDeveloper
    {
        public bool IsAzureCertified { get; set; }
        public bool IsAWSCertified { get; set; }


        public DevOpsEngineer(string fullname, int age, string address, long phoneNumber, bool isAzureCertified, bool isAWSCertified)
        : base(fullname, age, address, phoneNumber)
        {
            IsAzureCertified = isAzureCertified;
            IsAWSCertified  = isAWSCertified;
        }

        public override string GetProfessionalInfo()
        {
            string info = $"{FullName}";
            //info = info + " "
            info += IsAzureCertified ? " has Azure certificate" : " does not have Azure certificate";
            info += IsAWSCertified ? " has AWS certificate" : " does not have AWS certificate";
            return info;
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int> { 200, 202, 204 };
            return okStatuses.Contains(status);
        }

        //each class can implement the method differently, depending on the logic in that class
        public void Code()
        {
            if(IsAzureCertified)
            {
                Console.WriteLine("Writing code for Azure portal services");
            }

            if(IsAWSCertified)
            {
                Console.WriteLine("Writing code for AWS portal services");
            }
        }
    }
}
