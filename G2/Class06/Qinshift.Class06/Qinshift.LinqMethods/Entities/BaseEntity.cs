namespace Qinshift.Class06.LinqMethods.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
