using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Business.Language;
using Business.Utility;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Users.Controllers
{
    public class HomeController : Controller
    {
        private IKullaniciService _kullaniciService;

        public HomeController(IKullaniciService kullaniciService) {
            _kullaniciService = kullaniciService;
        }

        [Area("Users")]
        public IActionResult Index()
        {
            Dil dil = new Dil();
            string karsilama =  dil.DilVer(StaticFiles.dil).hosgeldiniz;
            ViewBag.karsilama = karsilama;
            var model = _kullaniciService.GetKullaniciListesi();
            return View(model);
        }
    }
}