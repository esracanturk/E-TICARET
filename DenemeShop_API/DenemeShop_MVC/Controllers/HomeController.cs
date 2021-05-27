using DenemeShop_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity;

namespace DenemeShop_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IAdminService _adminService;
        private IHostingEnvironment _environment;
        //private UserManager<IdentityUser> _userManger;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IAdminService adminService, IHostingEnvironment environment /*UserManager<IdentityUser> userManager*/)
        {
            _logger = logger;
            _productService = productService;
            _adminService = adminService;
            _environment = environment;
            //_userManger = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var loggedInUser = HttpContext.User;
            var loggedInUserName = loggedInUser.Identity.Name;
            return View();
        }
        public ActionResult GirisSayfa()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisSayfa(string username, string password)
        {
            var a = await _adminService.AdminFindUser(username, password);
            ViewBag.layout = 5;
            if (a == null)
            {
                ViewBag.Hata = "Geçersiz Kullanıcı Adı veya Şifre";
                return View();
            }
            else
            {
                if (a.role == true)
                {
                    HttpContext.Session.SetString("username", a.username);
                    HttpContext.Session.SetString("password", a.password);
                    HttpContext.Session.SetString("role", a.role.ToString());
                    HttpContext.Session.SetInt32("Id", a.userid);
                    //Response.Cookies.Append(key, value, cookieOptions);
                    var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name,a.username)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("AdminAnasayfa", "Product");
                }

                else
                {
                    HttpContext.Session.SetString("username", a.username);
                    HttpContext.Session.SetString("role", a.role.ToString());
                    HttpContext.Session.SetString("password", a.password);
                    HttpContext.Session.SetInt32("Id", a.userid);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,a.username)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("username");
            return RedirectToAction("GirisSayfa", "Home");
        }
        public async Task<IActionResult> ProductAra(string ara)
        {
            //var a = _productService.ProductGetAll();
            var a = await _productService.ProductAra(ara);
            Console.WriteLine(a);
            var json = JsonConvert.SerializeObject(a);
            return Json(new { Url = Url.Action("Index", "Home"), data = json });
        }
        public async Task<IActionResult> Register()
        {
            var degerler3 = true;
            var degerler4 = false;
            //var degerler2 = await _adminService.AdminGetAll();
            //ViewBag.deger2 = degerler2;
            ViewBag.deger3 = degerler3;
            ViewBag.deger4 = degerler4;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(GelenDataAPI user)
        {
            //if (!ModelState.IsValid)
            //{
            //    return RedirectToAction("GirisSayfa");
            //}
            await _adminService.RegisterUser(new GelenDataAPI()
            {
                userid = user.userid,
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm = user.emailconfirm
            });
            return RedirectToAction("GirisSayfa", "Home");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult KategoriDetay(int id)
        {
            ViewBag.x = id;
            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(Email email,int userId)
        {
            //string to = email.To;
            //string subject = email.Subject;
            //string body = email.Body;
            //MailMessage mail = new MailMessage();
            //mail.To.Add(to);
            //mail.Subject = subject;
            //mail.Body = body;
            //mail.From = new MailAddress("");
            //mail.IsBodyHtml = false;
            //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            //smtpClient.Port = 587;
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.EnableSsl = true;
            //smtpClient.Credentials = new System.Net.NetworkCredential("", "");
            //smtpClient.Send(mail);
            //ViewBag.mesaj = "Mail " + mail.To + " adresine gönderildi";
            //return View();


            using (MailMessage mm = new MailMessage("", email.To))
            {
                var c = await _adminService.GetByUser(userId);
                mm.Subject = "Hesap Aktivasyonu";
                string body = "Merhaba " + c.username+ ",";
                body += "<br /><br />Hesabınızı etkinleştirmek için lütfen aşağıdaki bağlantıyı tıklayın";
                body += "<br /><a href = '" + string.Format("{0}://{1}/Home/Aktifet/{2}", /*Request.Url.Scheme, Request.Url.Authority,*/ c.emailconfirm) + "'>Hesabınızı etkinleştirmek için burayı tıklayın.</a>";
                body += "<br /><br />Teşekkürler";
                mm.Body = body;
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-mail.outlook.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("", "Mail adresine ait şifreniz");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                return View();
            }
        }
    }
}
