using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Language
{
    public class Dil
    {

        public IDil DilVer(String hangiDil) {
            switch (hangiDil)
            {
                case "tr": return new Turkce();
                case "en": return new Ingilizce();
                case "de": return new Almanca();
                default:  return new Turkce();
            }
        }

    }
}
