using DenemeShop_MVC.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using CSharpVitamins;
using DenemeShop_MVC.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;

namespace DenemeShop_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IAdminService _adminService;
        private IHostingEnvironment _environment;
        //private UserManager<IdentityUser> _userManger;
        private HttpContext currentContext;

        public AccountController(ILogger<HomeController> logger, IProductService productService, IHttpContextAccessor httpContextAccessor, IAdminService adminService, IHostingEnvironment environment /*UserManager<IdentityUser> userManager*/)
        {
            _logger = logger;
            _productService = productService;
            _adminService = adminService;
            _environment = environment;
            currentContext = httpContextAccessor.HttpContext;
            //_userManger = userManager;
        }
        public ActionResult AccountSetting()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AccountSetting(GelenDataAPI data)
        {
            int? userIdd = HttpContext.Session.GetInt32("Id");
            var username2 = data.username;
            var email2 = data.email;
            var c = await _adminService.GetByUser(userIdd);
            await _adminService.UpdateUser(new GelenDataAPI()
            {
                userid = c.userid,
                username = username2,
                password = c.password,
                role = c.role,
                email = email2,
                emailconfirm = c.emailconfirm
            });
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(GelenDataAPI data)
        {
            int? userIdd = HttpContext.Session.GetInt32("Id");
            var password2 = data.password;
            var c = await _adminService.GetByUser(userIdd);
            await _adminService.UpdateUser(new GelenDataAPI()
            {
                userid = c.userid,
                username = c.username,
                password = password2,
                role = c.role,
                email = c.email,
                emailconfirm = c.emailconfirm
            });
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<ActionResult> ForgotPassword(string email)
        {
            using (MailMessage mm = new MailMessage("", email))
            {
                var request = currentContext.Request;
                Guid randomkey = Guid.NewGuid(); 
                ShortGuid randomkey2 = randomkey;
                var b = await _adminService.FindEmail(email);
                await _adminService.UpdateUser(new GelenDataAPI()
                {
                    userid = b.userid,
                    username = b.username,
                    password = randomkey2,
                    email = email,
                    role = b.role,
                    emailconfirm = b.emailconfirm
                });
                mm.Subject = "YENİ ŞİFRE";
                string body = "Merhaba " + "\n";
                //body += "<br /><br />Şifrenizi sıfırlamak için bağlantıya tıklayınız";
                //body += "<br /><br />Yeni şifreniz; " + randomkey2 + " Bağlantıya tıklayarak yeni şifreniz ile giriş yapabilirsiniz ";
                //body += "" + string.Format("{0}://localhost:44362/Account/SifreSifirla", request.Scheme) + "";
                body += "Yeni şifreniz; " + randomkey2 + "\n"+ "Bağlantıya tıklayarak yeni şifreniz ile giriş yapabilirsiniz; ";
                body += "" + string.Format("{0}://localhost:44362/Home/GirisSayfa", request.Scheme) + "";
                body += "\n"+"Teşekkürler";
                mm.Body = body;
                mm.IsBodyHtml = true;
                mm.From = new MailAddress("");
                mm.IsBodyHtml = false;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("", "");
                smtpClient.Send(mm);
            }
            return View();
        }

        public async Task<IActionResult> SifreSifirla()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SifreSifirla(string email, string password)
        {
            var b = await _adminService.FindEmail(email);
            await _adminService.UpdateUser(new GelenDataAPI()
            {
                userid = b.userid,
                username = b.username,
                password = password,
                email = email,
                role = b.role,
                emailconfirm = b.emailconfirm
            });

            return RedirectToAction("GirisSayfa", "Home");
        }

        public async Task<ActionResult> EmailConfirm()
        {
            int? userIdd = HttpContext.Session.GetInt32("Id");
            var a = await _adminService.GetByUser(userIdd);
            var email = a.email;
            using (MailMessage mm = new MailMessage("", email))
            {
                var request = currentContext.Request;
                mm.Subject = "HESAP AKTİVASYON MAİL";
                string body = "Merhaba " + "\n";
                body += "Hesabınızı aktif hale getirmek için linke tıklayınız; ";
                body += "<br /><a href = '" + string.Format("{0}://localhost:44362/Account/EmailConfirmUpdate", request.Scheme) + "'></a>";
                body += "<br /><br />Teşekkürler";
                mm.Body = body;
                mm.IsBodyHtml = true;
                mm.From = new MailAddress("");
                mm.IsBodyHtml = false;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("", "");
                smtpClient.Send(mm);
            }
            return View();
        }

        public async Task<ActionResult> EmailConfirmUpdate()
        {
            int? userIdd = HttpContext.Session.GetInt32("Id");
            var b = await _adminService.GetByUser(userIdd);
            await _adminService.UpdateUser(new GelenDataAPI()
            {
                userid = b.userid,
                username = b.username,
                password = b.password,
                email = b.email,
                role = b.role,
                emailconfirm = true
            });
            return RedirectToAction("Index", "Sepet");
        }
    }
}
