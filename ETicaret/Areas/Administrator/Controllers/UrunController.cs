using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using ETicaret.Areas.Administrator.Models;
using Entity.Entities;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ETicaret.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class UrunController : Controller
    {

        private readonly IHostingEnvironment _hostingEnvironment;
        IUrunService _urunService;
        IKategoriService _kategoriService;
        IMarkaService _markaService;
        IModelService _modelService;
        IOzellikService _ozellikService;
        IUrunresimService _urunresimService;
        IKategoriUrunService _kategoriUrunService;
        public UrunController(IUrunService urunService,
        IKategoriService kategoriService,
        IMarkaService markaService,
        IHostingEnvironment hostingEnvironment,
        IModelService modelService,
        IOzellikService ozellikService,
        IUrunresimService urunresimService,
        IKategoriUrunService kategoriUrunService) {
            _urunService = urunService;
            _kategoriService =kategoriService;
            _markaService=markaService;
            _modelService=modelService;
            _ozellikService=ozellikService;
            _urunresimService= urunresimService;
            _kategoriUrunService = kategoriUrunService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult UrunIslemleri() {
            ModelAdminUrunHome model = new ModelAdminUrunHome();
            model.UrunListesi = _urunService.GetAll();
            model.KategoriListesi = _kategoriService.GetKategoriListesi();
            model.Markalistesi = _markaService.GetAll();
            model.ModelListesi = _modelService.GetAll();
            model.ResimListesi = _urunresimService.GetAll();
            model.OzellikListesi = _ozellikService.GetAll();
            model.KategoriUrunList = _kategoriUrunService.GetAll();
            return View(model);
        }


        [HttpPost]
        public IActionResult Kaydet(ModelAdminUrunHome myModel) {
            // Sayfada ürün için seçilen tüm kategorilerin id lerini liste halinde aldık
            var liste = myModel.kategoriler;
            // Sayfa üzerinden gelen ürüne ait bilgileri kullanarak yeni bir ürün nesne oluşturduk.
            // içini sayfadan gelen bilgiler ile doldurduk.
            Tblurun urun = new Tblurun()
            {
                Ad = myModel.ad,
                Fiyat = myModel.fiyat,
                Aciklama = myModel.aciklama,
                IndirimliFiyat = myModel.indirimli_fiyat,
                Kdv = myModel.kdv,
                StokMiktari = myModel.stokmiktari
            };
            // ürünü kaydettik
            _urunService.Add(urun);

            TblkategoriUrun ku;
            // elimzde bulunan kategori listesi ile ürün arasında bağ kurmak için 
            // çapraz kategori_ürün tablosuna ekleme yaptık.
            foreach (var item in liste)
            {
                ku = new TblkategoriUrun() {
                    KategoriId = item,
                    UrunId = urun.Id
                };
                _kategoriUrunService.Add(ku);
            }

            var fileName = _hostingEnvironment.WebRootPath + @"\products\img\";
            myModel.UrunResim.CopyTo(new FileStream(fileName + myModel.UrunResim.FileName, FileMode.Create));
            string urunresimurl = "products/img/" + myModel.UrunResim.FileName;

            Tblurunresim resim = new Tblurunresim()
            {
                Anaresim = true,
                UrunId = urun.Id,
                UrunUrl = urunresimurl
            };
            _urunresimService.Add(resim);
            return RedirectToAction("UrunIslemleri");
        }
    }
}