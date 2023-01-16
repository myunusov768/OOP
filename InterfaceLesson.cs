using System;

namespace OOP1
{



    public class InterfaceLesson
    {
        public void Method(IAnimal animal)
        {
            animal.Mowe();
            Console.WriteLine(animal.Name);
            
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }

        public void Mowe()
        {
            Console.WriteLine("Animal");
        }   
    }
    public interface IAnimal1: IAnimal
    {
        public abstract string Name { get; set; }

        public abstract void Mowe();

    }
    public class Cow: IAnimal1
    {
        public string Name { get; set; } = "cow";
        

        public void Mowe()
        {
            Console.WriteLine("Cow");
        }
    }
    public class Cow1 : IAnimal
    {
        public string Name { get; set; } = "cow1";


    }
}
