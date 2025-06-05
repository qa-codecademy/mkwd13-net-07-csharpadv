using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinshift.OopAdv.Class15.Principles
{
    //BAD EXAMPLE
    public interface IMultipleFunDevice
    {
        void Print(string document);
        void Scan(string document);
        void Fax(string document);
    }
    public class OldPrinter : IMultipleFunDevice
    {
        public void Fax(string document)
        {
            throw new NotImplementedException();
        }

        public void Print(string document)
        {
            Console.Write(document);
        }

        public void Scan(string document)
        {
            throw new NotImplementedException();
        }
    }

    //GOOD EXAMPLE
    public interface IPrint
    {
        void Print(string document);
    }
    public interface IScan
    {
        void Scan(string document);
    }
    public interface IFax
    {
        void Fax(string document);
    }
    public class OldPrinterGood : IPrint
    {
        public void Print(string document)
        {
            Console.WriteLine(document);
        }
    }
}
