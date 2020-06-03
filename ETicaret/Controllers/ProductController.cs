using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Business.Abstract;
using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class ProductController : Controller
    {

        IUrunService _urunService;
        IUrunresimService _urunresimService;

        public ProductController(IUrunService urunService,
                                 IUrunresimService urunresimService) {
            _urunService = urunService;
            _urunresimService = urunresimService;
        }

       public IActionResult Index(int id)
        {
            ViewBag.isLogin = false;
            ModelProduct model = new ModelProduct();
            model.urun = _urunService.GetById(id);
            model.resimlistesi = _urunresimService.GetAll().Where(x=> x.UrunId==id).ToList();
            if (id == null || id == 0)
                return Redirect("/");
            else
                return View(model);
        }
    }
}