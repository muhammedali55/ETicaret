using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto.Request
{
    public class SepetRequestDto
    {
        public int urunid { get; set; }
        public int kullaniciid { get; set; }
        public string  urunadi { get; set; }
        public string resimurl { get; set; }
        public double fiyat { get; set; }
        public int adet { get; set; }
        public int id { get; set; }
    }
}
