using Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Models
{
    public class ModelHome
    {

        public List<SiteOnOff> siteOnOff { get; set; }
        public List<TblsiteSlider> listeSlider { get; set; }
        public List<TblkategorialaniHomedesign> kategoriList { get; set; }
        public TblsoneklenenlerHomedesign tblsoneklenenler { get; set; }
        public TbleniyilerHomedesign tbleniyiler { get; set; }
        public TbliletisimHomedesign tbliletisim { get; set; }
        public TblhtmltasarimHomedesign tblhtmltasarim { get; set; }
        public List<TblgaleriHomedesign> tblgaleri { get; set; }
        public String[] fileList { get; set; }
        public List<googleMapData> mapList { get; set; }
        public string filead { get; set; }
    }
    public class googleMapData { 
        public string baslik { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double zoom { get; set; }
        public string aciklama { get; set; }
    }
}
