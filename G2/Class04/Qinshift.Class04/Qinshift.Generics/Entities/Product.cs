namespace Qinshift.Generics.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string GetInfo()
        {
            return $"{Id}. {Name} - {Description}";
        }
    }
}
