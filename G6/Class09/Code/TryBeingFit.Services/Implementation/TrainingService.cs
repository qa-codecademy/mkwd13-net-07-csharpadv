using TryBeingFit.Domain.Database;
using TryBeingFit.Domain.Models;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interfaces;

namespace TryBeingFit.Services.Implementation
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        //the service communicates with the db
        //we use the interface - we dont want to be dependent on the implementation
        private IDatabase<T> _database;

        public TrainingService()
        {
            _database = new Database<T>(); //here we tell the _database which impl to execute when _database is called
        }
        public void AddTraining(T newTraining)
        {
            //1. validation
            if (newTraining == null)
            {
                throw new Exception("Training cannot be null");
            }
            //title is required
            if (string.IsNullOrEmpty(newTraining.Title))
            {
                throw new Exception("Title cannot be null");
            }
            //the training must have a trainer
            if(newTraining.Trainer == null)
            {
                throw new Exception("Each training must have a trainer");
            }

            //each training must be at least 10 min
            if (!ValidationHelper.ValidateTrainingDuration(newTraining.Time))
            {
                throw new Exception("Each training must be at least 10 min long");
            }

            //2. insert into the db
            _database.Insert(newTraining);
        }
    }
}
