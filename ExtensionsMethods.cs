using System;
using System.Runtime.CompilerServices;

namespace OOP
{
    /*Metodi raswireniya pozvolyaet ne sozdovaya proizvodniy class dobavit metodi*/
    public sealed class ExtensionsMethods
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Summ() => X + Y;

        public readonly int age = 500;
        public const int age1 = 500;
        public int Name { get; init; }


    }


    public static class ExtensionsMethods1
    {
        
        public static int Subtraction(this ExtensionsMethods extensionsMethods) => extensionsMethods.X - extensionsMethods.Y;
    }
}
