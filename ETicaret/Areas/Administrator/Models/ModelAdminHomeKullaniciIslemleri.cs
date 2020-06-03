using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Areas.Administrator.Models
{
    public class ModelAdminHomeKullaniciIslemleri
    {
        public List<Tblkullanici> KullaniciListesi { get; set; }
        public Tblkullanici tblkullanici { get; set; }
        
        public string Title { get; set; }
    }
}
