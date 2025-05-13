using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class Trainer : User, ITrainer
    {
        public int YearsOfExperience {  get; set; }

        public Trainer()
        {
            Role = UserRoleEnum.Trainer; //our trainer will always have the role Trainer
        }
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - {YearsOfExperience} years of experience";
        }

        public void Reschedule(LiveTraining liveTraining, int days)
        {
            //validation
            if(liveTraining == null)
            {
                throw new NullReferenceException("Training cannot be null");
            }
            //validation if it is the same trainer (another trainer cannot reschudule a live training that is not his)
            if(Id != liveTraining.Trainer.Id)
            {
                throw new Exception("You cannot reschedule this live trainer, because you are not the trainer for this live training");
            }
            liveTraining.NextSession = liveTraining.NextSession.AddDays(days);
        }
    }
}
