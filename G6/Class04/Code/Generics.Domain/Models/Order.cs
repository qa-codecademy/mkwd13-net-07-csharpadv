namespace Generics.Domain.Models
{
    public class Order : BaseEntity
    {
        public string OrderedBy { get; set; }
        public string Address { get; set; }

        public override string GetInfo()
        {
            return $"{OrderedBy} - {Address}";
        }
    }
}
