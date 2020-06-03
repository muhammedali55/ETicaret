using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class CardController : Controller
    {
        ISepetService _sepetService;
        public CardController(ISepetService sepetService) {
            _sepetService = sepetService;
        }

        public IActionResult Index()
        {
            ViewBag.isLogin = false;
            ModelCard model = new ModelCard();
            model.sepetListesi = _sepetService.GetSepetRequestDtobyUserid(1);
            return View(model);
        }

        public IActionResult Add(int id) {
            ViewBag.isLogin = false;
            Tblsepet sepet = new Tblsepet();
            Tblsepet mysepet = _sepetService.GetAll().Where(x=> x.UrunId==id).FirstOrDefault();
            if (mysepet == null)
            {
                sepet.UrunId = id;
                sepet.KullaniciId = 1;
                sepet.Adet = 1;
                _sepetService.Add(sepet);
            }
            else {
                mysepet.Adet += 1;
                _sepetService.Update(mysepet);
            }
          
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) {
            _sepetService.Delete(new Tblsepet() { Id = id });
            return RedirectToAction("Index");
        }
    }
}