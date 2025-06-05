namespace Qinshift.Principles.SOLID
{
    /*
        *** LISKOV SUBSTITUTION PRINCIPLE ***

        => LSP states that the child class should be perfectly substitutable for their parent class.
    */

    #region Without LSP
    // BAD EXAMPLE
    public class TriangleWithoutLSP
    {
        public virtual string GetShape()
        {
            return "Triangle";
        }
    }

    public class CircleWithoutLSP : TriangleWithoutLSP
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public class AppStartWithoutLSP
    {
        public static void Main()
        {
            TriangleWithoutLSP triangle = new CircleWithoutLSP();
            Console.WriteLine(triangle.GetShape()); // will print Circle
        }
    }

    #endregion


    #region With LSP

    // GOOD EXAMPLE

    public abstract class ShapeWithLSP
    {
        public abstract string GetShape();
    }

    public class TriangleWithLSP : ShapeWithLSP
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class CircleWithLSP : ShapeWithLSP
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }

    public class AppWithLSP
    {
        public static void Main()
        {
            ShapeWithLSP triangle = new TriangleWithLSP();
            Console.WriteLine(triangle.GetShape()); // will print Triangle
        }
    }

    #endregion
}
