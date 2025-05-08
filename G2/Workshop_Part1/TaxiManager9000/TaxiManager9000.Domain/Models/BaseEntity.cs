
namespace TaxiManager9000.Domain.Models
{
    public abstract class BaseEntity 
    {
        public int Id { get; set; }
        public abstract string Print();
    }
}
