using Business.Abstract;
using ETicaret.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.ViewComponents
{
    public class MenuViewComponent: ViewComponent
    {
        IKategoriService _kategoriService;
        public MenuViewComponent(IKategoriService kategoriService) {
            _kategoriService = kategoriService;
        }
        public IViewComponentResult Invoke() {
            ModelMenu model = new ModelMenu();
            model.listKategori = _kategoriService.GetKategoriListesi();
            return View(model);
        }
    }
}
