﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class GaleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}