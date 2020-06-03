using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Language
{
    class Turkce : IDil
    {
        public string hosgeldiniz 
        {
            get
            {
                return "Türkçe hoş geldniz";
            }
        }

        public string Home {
            get {
                return "AnaSayfa";
            }
        }
    }
}
