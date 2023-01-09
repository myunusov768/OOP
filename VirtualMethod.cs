using System;


namespace OOP
{
    public class VirtualMethod : Test
    {
        public override string NameVirtual { get; set; } = " Override name!";
        public new string NameSimple { get; set; } = "New simple name!";

        public override void Method1()
        {
            Console.WriteLine("Overide method!");
            Console.WriteLine(base.NameSimple);
            Console.WriteLine(NameSimple);
            Console.WriteLine(base.NameVirtual);
            Console.WriteLine(NameVirtual);


        }
        public new void Method2()
        {
            Console.WriteLine("New simple method!");
            base.Method2();
        }

    }

    public class Test
    {
        public virtual string NameVirtual { get; set; } = "Virtual name!";
        public string NameSimple { get; set; } = "Simple name!";

        public virtual void Method1() 
        {
            Console.WriteLine("virtual method!");
        }
        public void Method2() 
        {
            Console.WriteLine("simple method!");
        }
    }
}
