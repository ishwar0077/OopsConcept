using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class EncapsulationDemo
    {
        private int balance;
        public int accountNumber
        {
            get { return balance; }
            set { balance = value; }

        }

        public void Display()
        {
            Console.WriteLine(this.balance);
        }

        
    }
}
