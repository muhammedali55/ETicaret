using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class PersonelTanimlamaController : Controller
    {

        private UserManager<User> _userManager;

        public PersonelTanimlamaController(UserManager<User> userManager) {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(String Eposta, String Kullaniciadi, String Sifre) {

            User user = new User() {
                Email = Eposta,
                UserName = Kullaniciadi,
                PasswordHash = Sifre
            };

            var result =  await _userManager.CreateAsync(user, Sifre);
            if (!result.Succeeded)
            {
                ViewBag.hatalar = result.Errors;
            }
            return View();
        }

    }
}