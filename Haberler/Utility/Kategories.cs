using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Haberler.Utility.Sabitler;

namespace Haberler.Utility
{
    public class Kategories
    {
        public List<string> GetKategoriler(Language language)
        {
            switch (language)
            {
                case Language.TR:
                    return new List<string>() {
                        "İş",
                        "Eğlence",                     
                        "Sağlık",
                        "Bilim",
                        "Spor",
                        "Telnoloji"
                    };
                case Language.EN:
                    return new List<string>() {
                        "Business",
                        "Entertainment",                 
                        "Health",
                        "Science",
                        "Sport",
                        "Technology"
                    };
                case Language.DE:
                    return new List<string>() {
                        "Business",
                        "Entertainment",                  
                        "Health",
                        "Science",
                        "Sport",
                        "Technology"
                    };
                case Language.FR:
                    return new List<string>() {
                        "Affaires",
                        "Entertainment",                   
                        "Health",
                        "Science",
                        "Sport",
                        "Technology"
                    };
                default:
                    return new List<string>() {
                        "İş",
                        "Eğlence",                 
                        "Sağlık",
                        "Bilim",
                        "Spor",
                        "Telnoloji"
                    };
            }
        }
  
    
    }
}
