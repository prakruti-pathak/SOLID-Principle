using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    //Interface Segregation Principle (ISP):
    //A class should not be forced to implement interfaces it doesn’t use.
    public interface IPrint
    {
        void Print();
    }

    public interface IScan
    {
        void Scan();
    }

    public class SimplePrinter : IPrint
    {
        public void Print()
        {
            // Print logic
        }
    }


    //Violating ISP
    public interface IPrinter
    {
        void Print();
        void Scan();
    }

    public class SimplePrinter1 : IPrinter
    {
        public void Print()
        {
            // Print logic
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }


}
