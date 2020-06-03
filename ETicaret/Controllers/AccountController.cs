using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ETicaret.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.Controllers
{
    public class AccountController : Controller
    {
        // 1- ka. şif. girdi peki bu kişinin giriş yaptığın nerede tutacağız?
        // 2- bu kişinin kullanıcı bilgilerini nerede tutacağız?
        // 3- bu kişi nereye gitmek istiyordu? bu bilgiyi nereden alacağız? ve bu kişiyi
        //    gitmek istediği yere nasıl yönlendireceğiz?

        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager) {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult ForgotMyPassword() {
            ViewBag.isResult = "";
            return View();
        }

        [HttpPost]
        public IActionResult ForgotMyPassword(string email)
        {
            User user = _userManager.FindByEmailAsync(email).Result;
            if (user == null)
            {
                ViewBag.isResult = "Böyle bir email kayıtlı değildir. Lütfen kontrol ediniz.";
            }
            else
            {
                // Burada  e-postası gönderilen kişinin id bilgisine ulaşılır.
                string user_id = user.Id;
                // Reset_Table bir talonuz olacak. Bu tabloda oluşturulan Guid ve user id sisteme kayıt edilir.
                string uid = Guid.NewGuid().ToString()+"-"+user_id;
                // Sonrasında Sıfırlama yapmak için bir URL link hazırlanır.
                string UniqURL = "https://localhost:44383/Account/ResetPassword?UniqURL=" + uid;
                // bu link e-posta aracılığı ile kullanıcının vermiş olduğu e-posta adresine gönderilir.
                // E-Mail Entegrasyonu
                // C# İlgili E-Posta sunucusu için api sini eklemelisiniz.
                // E-Posta Sunucusuna sahip olmak, Gerekli mi? Hayır.
                // Google-gmail, Yahoo, Bing, v.b. eposta uygulamlarının entegrasyonunu yaparak kullanabilirsiniz.
                // Her hosting ve domain için bir e-posta sunucusu kurulur.
                // www.eticaretburada.com - info@eticaretburada.com
                // smtp - pop3 adreslerini verirler.
                // kullanıcı bu link tıklar ve ResetPassword Action una düşer 
                // Burada gelen guid alınarak kullanıcıya ait id bilgisi reset_taqble içinden bulunur
                // bulunan id ile kullanıcıdan alınan yeni şifre bilgisine göre kullanıcının şifresi güncellenir.


                ViewBag.isResult = "Şifre Sıfırlama için Link e-posta adresinize gönderilmiştir.";
            }
            return View();
        }


        public IActionResult ResetPassword(string UniqURL) {

            // Gelen UniqURL alıp, Reset_Table tablosundan Guid ile değiştirilecek olan kullanınıcı id si bulunur.

            int lastIndex = UniqURL.LastIndexOf("-");
            string id = UniqURL.Substring(lastIndex + 1);
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetSubmitPassword(string password,string id)
        {
            User user = _userManager.FindByIdAsync(id).Result;
            user.sifre = password;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Login");
        }

     

     

        public IActionResult FacebookLogin()
        {
            return View();

        }

        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string ReturnUrl, string kullaniciadi, string sifre) {
            // Öncelikle böyle bir kullanıcı var mı diye bak 
            // yani email ile bu kişiyi çek
            var user = _userManager.FindByEmailAsync(kullaniciadi);
            //Eğer böyle bir e postaya sahip birisi var ise  işlem yap
            if (user != null) {
                // burada iki durum olabilir. daha önce bir oturum olabilir.
                await _signInManager.SignOutAsync();
                // Burada kullanıcı adı ve şifresi verilen kişiye oturum aç.
                var result = await _signInManager
                    .PasswordSignInAsync(kullaniciadi, sifre, false, false);
                // Eğer baraşı ile oturum acılmış ise kişiyi istediği sayfaya yönlendiririz.
                if (result.Succeeded)
                    if (ReturnUrl == null)
                        return Redirect("~/Administrator/Home/Index");
                    else
                        return Redirect(ReturnUrl);
            }
            // yukarıdaki işlemlerden kullanıcı hiç bir yere yönlendirilmez ise Login 
            // sayfasına tekrar gönderilir.
            ViewBag.hata = "Kullanıcı adı yada Şifre Hatalı";
            return View();

        }


        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user) {
            try
            {
                user.UserName = user.kullaniciadi;
                var result = await _userManager.CreateAsync(user, user.sifre);
                if (!result.Succeeded)
                {
                    ViewBag.hatalar = result.Errors;
                    return View();
                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                string hata = ex.ToString();
                return View();
            }            
        }
    }
}