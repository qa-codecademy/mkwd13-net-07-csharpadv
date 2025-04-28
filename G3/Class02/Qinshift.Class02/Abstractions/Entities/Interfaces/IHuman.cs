namespace Abstractions.Entities.Interfaces
{
    /*
        => Interface IS NOT a type of class. It is an entity on its own.
        => Interfaces define a contract (set of members => methods, properties..) for classes to implement
        => Doesn't hold any implementation
        => The classes that implement (inherit) the interface MUST provide implementation for all of it's members !!!
     
        *Usecases* => Contract definitions, multiple inheritance, polymorphism, dependency injection* (*will be covered later on in the academy curiculum) 
     */
    public interface IHuman
    {
        // Methods Signatures => <return type> <method name> (<params if any>)
        string GetInfo();
        string GetFullName();
        void Greet(string name);
        // In most cases, Interfaces are used only for Methods signatures !!!
        string Email { get; set; } // rarely used

    }
}
