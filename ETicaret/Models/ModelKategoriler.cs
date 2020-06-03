using Business.Dto.Request;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class ModelKategoriler
    {
        // Kategori id
        // Kategori Adı
        // Alt Kategori Listesi
        // Alt Kategori ya da Ana Kategori ye ait Ürün Listesi
        public ModelHeader header { get; set; }
        public List<Tblkategori> KategoriListesi { get; set; }
        public Tblkategori Anakategori { get; set; }
        public Tblkategori Altkategori { get; set; }
        public List<KategoriRequestDto> KategoriRequestDtoList { get; set; }
    }
}
