using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using ETicaret.Areas.Administrator.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class SliderController : Controller
    {
        // IOC
        ISiteSliderService _siteSliderService;
        // Local olabilir yada web hos içinde olabilir bir noktaya kayıt yapmamız gereklidir.
        // bu bakımdan lokal bir alan kullanmak çok dğru bir seçim değildir.
        // web üzerinde çalışan bir sistemin web de bulunan bir lokasyona kaydı yapılmalıdır.
        // 
        private readonly IHostingEnvironment _hostingEnvironment;
        public SliderController(ISiteSliderService siteSliderService,
                                IHostingEnvironment hostingEnvironment) {
            _siteSliderService = siteSliderService;
            _hostingEnvironment = hostingEnvironment;
        }

        // Slider Ana Sayfasını Açmak için kullanıoyruz.
        public IActionResult Index()
        {
            ModelAdminSlider model = new ModelAdminSlider();
            model.listeSlider = _siteSliderService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ModelAdminSlider model) {

            TblsiteSlider myModel = new TblsiteSlider();
            myModel.Ad = model.Ad;
            myModel.Altbaslik = model.Altbaslik;
            myModel.Baslik = model.Baslik;
            myModel.Butonlinkurl = model.Butonlinkurl;
            myModel.Butontext = model.Butontext;
            myModel.Discount = model.Discount;

            var fileName = _hostingEnvironment.WebRootPath + @"\assets\img\hero\";
            model.Frontimgurl.CopyTo(new FileStream(fileName + model.Frontimgurl.FileName, FileMode.Create));
            model.Backimgurl.CopyTo(new FileStream(fileName + model.Backimgurl.FileName, FileMode.Create));
            myModel.Frontimgurl = "assets/img/hero/" + model.Frontimgurl.FileName;
            myModel.Backimgurl = "assets/img/hero/" + model.Backimgurl.FileName;
            _siteSliderService.Add(myModel);

            return RedirectToAction("Index");
        }

        public IActionResult SliderSil(int id) {
            var model = _siteSliderService.GetById(id);
            _siteSliderService.Delete(model);
            return RedirectToAction("Index");
        }
    }
}