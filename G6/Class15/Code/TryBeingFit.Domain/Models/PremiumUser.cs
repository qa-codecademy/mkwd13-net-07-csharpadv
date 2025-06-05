using TryBeingFit.Domain.Enums;
namespace TryBeingFit.Domain.Models
{
    public class PremiumUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public PremiumUser()
        {
            Role = UserRoleEnum.Premium;
            VideoTrainings = new List<VideoTraining>();
        }
        public override string GetInfo()
        {
           string liveTrainingMessage = LiveTraining ==  null ? "no live trainings" : LiveTraining.GetInfo();
           return $"{FirstName} {LastName}, number of video trainings: {VideoTrainings.Count}, live training: {liveTrainingMessage}";
        }
    }
}
