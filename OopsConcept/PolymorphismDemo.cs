using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class PolymorphismDemo
    {
        public virtual void add()
        {
            int c = 10+10;
            Console.WriteLine("this is parent class ");
        }
        public void add(int a)
        {
            int b = a;
        }
        public void add(string s)
        {
            string str = s;
        }
        public void add(int a, string s) //overloading
        {
            int b = a;
            string str = s;

        }


    }
    public class demo1 : PolymorphismDemo
    {
        public override void add()
        {
            Console.WriteLine("Overriding done in child class");
        }
    }

}
