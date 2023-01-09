using System;


namespace OOP
{
    public class AbstractType
    {
        Animal fish = new Fish("ss");
        public void Method()
        {
            fish.Mowe();

        }


    }
    public abstract class Animal
    {
        public Animal(string name) 
        {
            Name= name;
        }
        public abstract string Name { get; set; }
        public abstract AnimalType Type { get; set; }
        public abstract void Mowe();
    }

    public class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
            Name= name;
        }

        public override string Name { get ; set ; }
        public override AnimalType Type { get; set ; }

        public override void Mowe()
        {
            Console.WriteLine("Fish");
        }

        public void Method()
        {
            Console.WriteLine("Fish Method");
        }


    }
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            Name= name;
        }

        public override string Name { get; set ; }
        public override AnimalType Type { get; set; }

        public override void Mowe()
        {
            Console.WriteLine("Bird");
        }
        public void Method()
        {
            Console.WriteLine("Bird Method");
        }

    }
    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
        Amphibian,
        Invertebrate,
        Fish
    }
}
