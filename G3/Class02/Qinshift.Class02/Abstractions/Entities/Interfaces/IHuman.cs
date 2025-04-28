namespace Abstractions.Entities.Interfaces
{
    public interface IHuman
    {
        string GetInfo();
        string GetFullName();
        void Greet(string name);
        string Email { get; set; }

    }
}
