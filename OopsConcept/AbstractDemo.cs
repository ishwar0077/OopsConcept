using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public abstract class AbstractDemo
    {
        public abstract void AddNum();
        public void display()
        {
            Console.WriteLine("this is a abstract class");
        }
    }

    public class Operation : AbstractDemo 
    {
        public override void AddNum() //implimentation of abstract method
        {
            int a = 10 + 20;
            Console.WriteLine(a);
        }
    }
}
