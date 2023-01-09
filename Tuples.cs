using System;

namespace OOP
{
    public class Tuples
    {
        //tuple - eto nabor zncheniy s raznimi tipami

        public void TupleMethod()
        {
            (string, int) tuple = ("ss", 5);


            Console.WriteLine($"Item1 {tuple.Item1}, Item2 {tuple.Item2}");
            var (name, age) = ("salom", 4);

            Console.WriteLine(name + age);
            Console.WriteLine(TupleMethod2());

        }
        public (string, int) TupleMethod2() => ("Salom", 5);
        
    }
}
