using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.OopAdv.Class15.Principles
{
    //BAD EXAMPLE
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly");
        }
    }
    public class  Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    //GOOD EXAMPLE
    public abstract class BirdGood
    {
        public string Name { get; set; }
    }

    public interface IFly
    {
        void Fly();
    }

    public class PenguinGood : BirdGood
    {
        //Code.......
    }
}
