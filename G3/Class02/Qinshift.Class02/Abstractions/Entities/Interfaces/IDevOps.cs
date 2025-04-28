namespace Abstractions.Entities.Interfaces
{
    // Interfaces can contain other interfaces directly
    // Meaning the classes that implement IDevOps would also need to implement the other interfaces as well
    public interface IDevOps : IOperations, IDeveloper
    {
    }
}
