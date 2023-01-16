using System;


namespace OOP
{
    public interface IPerson
    {
        string Name { get; }
        int Id { get; }
        public void Method()
        {
            Console.WriteLine("Salom");
        }
    }
    public interface IPerson1
    {
        string Name { get; }
        int Id { get; }
        public abstract void Method();
        
    }

}
