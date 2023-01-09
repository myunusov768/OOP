using System;
using System.Drawing;

namespace OOP
{
    public class AnonymousType
    {
        public void Method()
        {
            var _car = new { speed = 300, marca = "Toyota" };
            var _car1 = new { speed = 300, marca = "Toyota" };
            var _car2 = new { speed = 200, marca = "Toyota", Colour = "Red" };

            var _car3 = _car with { speed = 300, marca = "Jip" }; 

            Console.WriteLine(_car);
            Console.WriteLine(_car1);
            Console.WriteLine(_car2);
            Console.WriteLine(_car.GetType().Name);
            Console.WriteLine(_car1.GetType().Name);
            Console.WriteLine(_car2.GetType().Name);
            //sravnenie na ravenstvo provoditsya po znacheniyu
            Console.WriteLine(_car.Equals(_car1));

        }

    }
}
