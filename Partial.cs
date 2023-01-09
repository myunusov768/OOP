using System;

namespace OOP
{
    //partial class
    public partial class Partial
    {
        //partial methods
        /* Odno chast soderjit signature metoda a drugaya chast realizatsiya, mozhno ne realizovat metodi s signaturam void, Private */
        public partial int PartialMetod();
        partial void OnPartialMetod();

    }



    public partial class Partial 
    {
        public partial int PartialMetod()
        {
            throw new NotImplementedException();
        }

    }

}
