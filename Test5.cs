using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Test5: Test6
    {
        public new string Name { get; set; } = "new";


        public override string Name1 { get; set; } = "override";
        public override void Method1()
        {
            Console.WriteLine("override");
        }

        public new void Method()
        {
            Console.WriteLine("new");
            base.Method();
        }


    }

    public class Test6
    {
        public virtual string Name1 { get; set; } = "base";

        public string Name { get; set; } = "base";
        public void Method()
        {
            Console.WriteLine("base");
        }
        public virtual void Method1()
        {
            Console.WriteLine("base");
        }
    }

}
