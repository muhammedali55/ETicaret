using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using ETicaret.Areas.Administrator.Models;
using Entity.Entities;
using Microsoft.AspNetCore.Authorization;

namespace ETicaret.Areas.Administrator.Controllers
{
    [Area("Administrator")] 
    [Authorize]
    public class HomeController : Controller
    {
        IKullaniciService _kullaniciService;
        ModelAdminHomeKullaniciIslemleri _myKullaniciModel;
        public HomeController(IKullaniciService kullaniciService) {
            _kullaniciService = kullaniciService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {            
            return View();
        }
        // Default Actions -> HttpGet
        public IActionResult KullaniciIslemleri() {
            _myKullaniciModel = new ModelAdminHomeKullaniciIslemleri();
            _myKullaniciModel.KullaniciListesi = _kullaniciService.GetKullaniciListesi();
            _myKullaniciModel.Title = "Kullanıcı ekleme sayfası";
            return View(_myKullaniciModel);
        }

        //Sayfa tarafından form gönderme işlemi -> HttpPost
        [HttpPost]
        public IActionResult KullaniciIslemleri(Tblkullanici item) {
            // Veritabanına kayit işini görecektir.
            _kullaniciService.Add(item);
            return RedirectToAction("KullaniciIslemleri");
        }

        [HttpPost]
        public IActionResult Kullanicisil(int id) {
            _kullaniciService.Delete(new Tblkullanici()
            {
                Id = id
            });
            return RedirectToAction("KullaniciIslemleri");
        }

        [HttpPost]
        public IActionResult KullaniciDuzenle(Tblkullanici item) {
            _kullaniciService.Update(item);
            return RedirectToAction("KullaniciIslemleri");
        }
    }
}