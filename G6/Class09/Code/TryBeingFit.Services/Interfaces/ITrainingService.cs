using TryBeingFit.Domain.Models;

namespace TryBeingFit.Services.Interfaces
{
    public interface ITrainingService<T> where T : Training
    {
        void AddTraining(T newTraining);
    }
}
