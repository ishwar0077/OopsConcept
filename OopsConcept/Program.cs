namespace OopsConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InheritanceDemo obj1 = new InheritanceDemo();
            //obj1.add();
            //child aob2 = new child();
            //aob2.sub();

            //PolymorphismDemo pobj1 = new PolymorphismDemo();
            //pobj1.add(8);
            //pobj1.add("ishwar");
            //pobj1.add(8, "demo");

            //demo1 dobj = new demo1();
            //dobj.add();

            //Operation op1 = new Operation();
            //op1.AddNum();

            EncapsulationDemo eobj = new EncapsulationDemo();
            eobj.accountNumber = 10;
            //Console.WriteLine(eobj.accountNumber);

            eobj.Display();
        }
    }
}
