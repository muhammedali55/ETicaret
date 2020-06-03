using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Language;
using Entity.Entities;
using ETicaret.Authentication;
using ETicaret.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class HomeController : Controller
    {
        IKullaniciService _kullaniciService;
        IKategoriService _kategoriService;
        IKategoriUrunService _kategoriUrunService;
        IUrunService _urunService;
        IUrunresimService _urunresimService;
        ISiteSliderService _siteSliderService;
        IKategorialani_homedesignService _kategorialani_HomedesignService;
        ISoneklenenlerHomedesignService _soneklenenlerHomedesignService;
        IEniyilerHomedesignService _eniyilerHomedesignService;
        IİletisimHomedesignService _iletisimHomedesignService;
        IGaleriHomedesignService _galeriHomedesignService;
        IHtmltasarimHomedesignService _htmltasarimHomedesignService;
        private readonly IHostingEnvironment _hostingEnvironment;
        public HomeController(IKullaniciService kullaniciService,
                            IKategoriUrunService kategoriUrunService,
                            IUrunService urunService,
                            IUrunresimService urunresimService,
        IHostingEnvironment hostingEnvironment,
                            IKategoriService kategoriService,
                              ISiteSliderService siteSliderService,
                              IKategorialani_homedesignService kategorialani_HomedesignService,
                              ISoneklenenlerHomedesignService soneklenenlerHomedesignService,
                              IEniyilerHomedesignService eniyilerHomedesignService,
                              IİletisimHomedesignService iletisimHomedesignService,
                              IGaleriHomedesignService galeriHomedesignService,
                              IHtmltasarimHomedesignService htmltasarimHomedesignService) {
            _kullaniciService = kullaniciService;
            _kategoriService = kategoriService;
            _siteSliderService = siteSliderService;
            _kategorialani_HomedesignService = kategorialani_HomedesignService;
            _soneklenenlerHomedesignService = soneklenenlerHomedesignService;
            _eniyilerHomedesignService = eniyilerHomedesignService;
            _iletisimHomedesignService = iletisimHomedesignService;
            _galeriHomedesignService = galeriHomedesignService;
            _htmltasarimHomedesignService = htmltasarimHomedesignService;
            _kategoriUrunService = kategoriUrunService;
            _urunService = urunService;
            _hostingEnvironment = hostingEnvironment;
            _urunresimService = urunresimService;
        }
        
        public async Task<IActionResult> Index()
        {
            //User user = new User();
            //user.Email = "muhammet@gmail.com";
            //user.PasswordHash = "Aa123456*";
            //user.UserName = "muhammet";

            //var durum = await _user.CreateAsync(user, "Aa123456*");

           // var fileName = _hostingEnvironment.WebRootPath + @"\assets\img\hero\";
            //string[] fileList = Directory.GetFiles(fileName);
          
            Dil dil = new Dil();
            string home = dil.DilVer("en").Home;
            ViewBag.isLogin = false;
            ModelHome model = new ModelHome();
            model.listeSlider = _siteSliderService.GetAll();
            model.kategoriList = _kategorialani_HomedesignService.GetAll();
            model.tblsoneklenenler = _soneklenenlerHomedesignService.GetAll().FirstOrDefault();
            model.tbleniyiler = _eniyilerHomedesignService.GetAll().FirstOrDefault();
            model.tbliletisim = _iletisimHomedesignService.GetAll().FirstOrDefault();
            model.tblgaleri = _galeriHomedesignService.GetAll();
            model.tblhtmltasarim = _htmltasarimHomedesignService.GetAll().FirstOrDefault();
            model.fileList = null;
            model.siteOnOff = new List<SiteOnOff>() {
                new SiteOnOff(){  id=1, durum=true },
                new SiteOnOff(){  id=2, durum=true },
                new SiteOnOff(){  id=3, durum=true },
                new SiteOnOff(){  id=4, durum=true },
                new SiteOnOff(){  id=5, durum=true },
                new SiteOnOff(){  id=6, durum=true },
                new SiteOnOff(){  id=7, durum=true },
                new SiteOnOff(){  id=8, durum=true },

            };
            // Anasayfada ki Google Haritası için gerekli içerikliri ekliyoruz
            // bu işlem burada elle yapılmıştır
            // ancak, bu işlem veritabanında tutulan bilgiler çekiilerek te yapılabilir.
            model.mapList = new List<googleMapData>() { 
                new googleMapData(){ 
                    baslik = "Gençlik Parkı",
                    lat = 39.932363,
                    lon = 32.852419,
                    zoom = 5,
                    aciklama = "<div id=\"content\">" +
            "<div id=\"siteNotice\">" +
            "</div>" +
            "<h1 id=\"firstHeading\" class=\"firstHeading\">GENÇLİK PARKI HAKKINDA</h1>" +
            "<div id=\"bodyContent\">" +
            "<p><b>GENÇLİK PARKI</b>, also referred to as <b>Ayers Rock</b>, is a large " +
            "sandstone rock formation in the southern part of the " +           
            "Heritage Site.</p>" +
            "<p>Attribution: Uluru, <a href=\"https://en.wikipedia.org/w/index.php?title=Uluru&oldid=297882194\">" +
            "https://en.wikipedia.org/w/index.php?title=Uluru</a> " +
            "(last visited June 22, 2009).</p>" +
            "</div>" +
            "</div>"
        },
                new googleMapData(){
                    baslik = "Kuğulu Park",
                    lat = 39.905218,
                    lon = 32.867209,
                    zoom = 5,
                       aciklama =  "<div id=\"content\">" +
            "<div id=\"siteNotice\">" +
            "</div>" +
            "<h1 id=\"firstHeading\" class=\"firstHeading\">KUĞULU PARK HAKKINDA</h1>" +
          "<div id=\"bodyContent\">" +
            "<p><b>KUĞULU</b>, also referred to as <b>Ayers Rock</b>, is a large " +
            "sandstone rock formation in the southern part of the " +
            "Heritage Site.</p>" +
            "<p>Attribution: Uluru, <a href=\"https://en.wikipedia.org/w/index.php?title=Uluru&oldid=297882194\">" +
            "https://en.wikipedia.org/w/index.php?title=Uluru</a> " +
            "(last visited June 22, 2009).</p>" +
            "</div>" +
            "</div>"
                },
                   new googleMapData(){
                    baslik = "Binmeyen bir Yer",
                    lat = 39.915218,
                    lon = 32.867209,
                    zoom = 5,
                       aciklama =  "<div id=\"content\">" +
            "<div id=\"siteNotice\">" +
            "</div>" +
            "<h1 id=\"firstHeading\" class=\"firstHeading\">HERHANGİ BİR YER</h1>" +
           "<div id=\"bodyContent\">" +
            "<p><b>BİR YER</b>, also referred to as <b>Ayers Rock</b>, is a large " +
            "sandstone rock formation in the southern part of the " +
            "Heritage Site.</p>" +
            "<p>Attribution: Uluru, <a href=\"https://en.wikipedia.org/w/index.php?title=Uluru&oldid=297882194\">" +
            "https://en.wikipedia.org/w/index.php?title=Uluru</a> " +
            "(last visited June 22, 2009).</p>" +
            "</div>" +
            "</div>"
                }
            };
           return View(model);
        }

        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String kullaniciadi, String sifre)
        {
            var item = _kullaniciService.isLogin(kullaniciadi, sifre);
            if (item == null)
                return View();
            else
            {
                switch (item.Kullaniciadi)
                {
                    case "administrator": return Redirect("~/Administrator");
                    case "muhammethoca": return Redirect("~/KullaniciPaneli");
                    default: return View();
                   
                }

            }
        }

        public async Task<IActionResult> Kategoriler(int id) {
            ViewBag.isLogin = false;
            //ViewBag.KategoriID = id;
            ModelKategoriler model = new ModelKategoriler();
            model.Anakategori = _kategoriService.GetKategoriToId((int)id);
            // Kategori id si gelen kategoriye ait tüm alt kategorileri çek
            model.KategoriListesi = _kategoriService.GetSubKategoriList(id);
            model.KategoriRequestDtoList = _urunService.GetAllByUrunKategoriDto(id);
            return View(model);
        }

        public async Task<IActionResult> AltKategoriler(int id)
        {
            ViewBag.isLogin = false;          
            ModelKategoriler model = new ModelKategoriler();
            try
            {
                model.Altkategori = _kategoriService.GetKategoriToId(id);
                model.Anakategori = _kategoriService.GetKategoriToId((int)model.Altkategori.ParentId);
                model.KategoriListesi = _kategoriService.GetSubKategoriList(id);
                model.KategoriRequestDtoList = _urunService.GetAllByUrunKategoriDto(id);
            }
            catch (Exception ex)
            {
                string hata = ex.ToString();
            }
             
            return View("Kategoriler", model);
        }


    }
}