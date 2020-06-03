using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Haberler.Utility
{
    public static class Sabitler
    {
        public enum Kategoriler {
            business,
            entertainment,            
            health,
            science,
            sports,
            technology
        }

        public enum Language {
            TR = 48,
            EN = 51,
            DE = 13,
            FR = 15
        }


        public static List<Dil> Diller() {
            return new List<Dil>(){
               new Dil(){ 
                id = 48,
                country = "Türkçe"
               },
               new Dil(){
                id = 51,
                country = "English"
               },
               new Dil(){
                id = 13,
                country = "German"
               },new Dil(){
                id = 15,
                country = "France"
               }
            };
        }      
       
    }
    public class Dil{
        public int id { get; set; }
        public string country { get; set; }
    }

}

