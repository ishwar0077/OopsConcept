using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class InheritanceDemo
    {
        public void add()
        {
            int a = 10, b = 20;
            int c = a + b;
            Console.WriteLine("this is a base class: {0}", c);
        }
    }
    public class child : InheritanceDemo
    {
        public void sub()
        {
            int a = 10, b = 21;
            int c = b - a;
            Console.WriteLine("This is child class: {0} ", c);
        }
    }
}


