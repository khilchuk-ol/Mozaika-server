using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Base ex = new Derived();
            ex.Method();
        }
    }

    public abstract class Base
    {
        public virtual void Method()
        {
            Console.WriteLine("Base");
        }
    }

    public sealed class Derived : Base
    {
        public override void Method()
        {
            Console.WriteLine("Derived");
        }
    }
}
