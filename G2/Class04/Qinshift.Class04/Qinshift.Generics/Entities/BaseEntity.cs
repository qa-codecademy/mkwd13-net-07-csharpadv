namespace Qinshift.Generics.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract string GetInfo();
    }
}
