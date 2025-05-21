using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Models
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {

            VideoTrainings = new List<VideoTraining>();
            Role = UserRoleEnum.Standard;
        }
        public override string GetInfo()
        {
            string result = $"{FirstName} {LastName}";
            result += "\n Video trainings: \n";
            foreach (VideoTraining videoTraining in VideoTrainings)
            {
                result += $"{videoTraining.GetInfo()} \n";
            }
            return result;
        }
    }
}
