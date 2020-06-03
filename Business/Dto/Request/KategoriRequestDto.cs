using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto.Request
{
    public class KategoriRequestDto
    {
        public string resimurl { get; set; }
        public int urunid{ get; set; }
        public string ad{ get; set; }
        public string aciklama { get; set; }
        public double fiyat { get; set; }

    }
}
