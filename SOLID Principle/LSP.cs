using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle
{
    //Liskov Substitution Principle (LSP):
    //Derived classes must be substitutable for their base classes.
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
    //Implementing LSP principle where you can overide the base method
    public class Sparrow : Bird
    {
        public override void Fly()
        {
            // Logic for Sparrow flying
        }
    }
    //This is Violating LSP Principle
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Ostrich can't fly!");
        }
    }
}
