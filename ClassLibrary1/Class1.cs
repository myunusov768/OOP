namespace ClassLibrary1
{
    public class ADefoult
    {
        public string aPublic = "public";
        private string aPrivate = "private";
        internal string aInterbal = "internal";
        protected string aProtected = "protected";
        protected internal string aProtectedInternal = "protected internal";
        private protected string aPrivateProtected = "private protacted";

        public void PrintPublic() { Console.WriteLine(aPublic); }
        private void PrintPrivate() { Console.WriteLine(aPrivate); }
        protected void PrintProtected() { Console.WriteLine(aProtected); }
        internal void PrintInternal() { Console.WriteLine(aInterbal); }
        protected internal void PrintProtectedInternal() { Console.WriteLine(aProtectedInternal); }
        private protected void PrintPrivateProtected() { Console.WriteLine(aPrivateProtected); }

    }
    class DefoultB : ADefoult
    {
        ADefoult aDefoult = new ADefoult();

        public void Print()
        {
            Console.WriteLine(aPublic);
            Console.WriteLine(aInterbal);
            Console.WriteLine(aPrivate);
            Console.WriteLine(aProtected);
            Console.WriteLine(aProtectedInternal);
            Console.WriteLine(aPrivateProtected);
            //------------------------------------
            aDefoult.PrintPublic();
            aDefoult.PrintInternal();
            aDefoult.PrintPrivate();
            aDefoult.PrintProtected();
            aDefoult.PrintProtectedInternal();
            aDefoult.PrintPrivateProtected();


        }


    }
}