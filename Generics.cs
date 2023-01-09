using System;

namespace OOP
{
    public sealed class Generics<T>
        where T : class//, IPerson
    {

        public void Print()
        {
            Console.WriteLine("Salom");
        }

        public Generics() { }

    }
}
