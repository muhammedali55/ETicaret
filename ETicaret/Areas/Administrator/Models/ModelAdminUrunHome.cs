using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace ETicaret.Areas.Administrator.Models
{
    public class ModelAdminUrunHome
    {
        public List<Tblurun> UrunListesi { get; set; }
        public List<Tblmarka> Markalistesi { get; set; }
        public List<Tblmodel> ModelListesi { get; set; }
        public List<Tblurunresim> ResimListesi { get; set; }
        public List<Tblkategori> KategoriListesi { get; set; }
        public List<Tblozellik> OzellikListesi { get; set; }
        public List<TblkategoriUrun> KategoriUrunList { get; set; }
        public string ad { get; set; }
        public string aciklama { get; set; }
        public double fiyat { get; set; }
        public double indirimli_fiyat { get; set; }
        public int stokmiktari { get; set; }
        public int kdv{ get; set; }
        public List<int> kategoriler { get; set; }
        public int marka { get; set; }
        public int model { get; set; }
        public IFormFile UrunResim { get; set; }

    }
}
