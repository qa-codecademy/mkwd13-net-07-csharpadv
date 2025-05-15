using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Qinshift.Events.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public bool HasWokeUp { get; set; } = false;
        public void WakeUp()
        {
            Console.WriteLine($"{Name} waaaaaaake uup!!!");
            HasWokeUp = true;
        }
    }
}
