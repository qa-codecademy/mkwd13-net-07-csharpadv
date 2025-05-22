using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession {get; set;}
        public override string GetInfo()
        {
            return $"{Title} - {Description}, lasts: {Time}, date: {NextSession.Date}, trainer: {Trainer.GetInfo()}";
        }

        public int HoursToNextSession()
        {
           return (NextSession - DateTime.Now).Hours;
        }
    }
}
