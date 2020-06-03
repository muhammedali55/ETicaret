using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Authentication
{
    public class User: IdentityUser
    {
        // Özelleştirilmiş alanlar ekleyebiliriz.
        public string tckimlikno { get; set; }
        public string kullaniciadi { get; set; }
        public string ad { get; set; }
        public string  soyad { get; set; }
        public string sifre { get; set; }

    }
}
