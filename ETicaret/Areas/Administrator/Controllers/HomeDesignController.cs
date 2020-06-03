using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Areas.Administrator.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class HomeDesignController : Controller
    {
        public IActionResult Index()
        {
            ModelAdminHomeDesign model = new ModelAdminHomeDesign();
            model.ListetblsiteHomedesigns = new List<Entity.Entities.TblsiteHomedesign>();
            return View(model);
        }
    }
}