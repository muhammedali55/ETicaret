using Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Areas.Administrator.Models
{
    public class ModelAdminSlider
    {
        public string Ad { get; set; }
        public string Discount { get; set; }
        public string Baslik { get; set; }
        public string Altbaslik { get; set; }
        public string Butontext { get; set; }
        public string Butonlinkurl { get; set; }
        // Dosya olarak gelen verileri yakalayacağız.
        // Resim Image -> olarak alınabilir.
        // resim, pdf, docx,xls,xml, mp3,mp4
        public IFormFile Backimgurl { get; set; }
        public IFormFile Frontimgurl { get; set; }

        public List<TblsiteSlider> listeSlider { get; set; }
    }
}
