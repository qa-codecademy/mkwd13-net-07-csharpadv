namespace AdvancedLINQ.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract void PrintInfo();
    }
}
