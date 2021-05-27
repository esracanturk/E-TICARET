using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using DenemeShop_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;

namespace DenemeShop_MVC.Controllers
{
    //[Authorize]
    public class SepetController : Controller
    {
        private readonly ISepetService _sepetService;
        private readonly IProductService _productService;
        private readonly IAdminService _adminService;
        public SepetController(ISepetService sepetService, IProductService productService, IAdminService adminService)
        {
            _sepetService = sepetService;
            _productService = productService;
            _adminService = adminService;
        }

        //[Authorize]
        public async Task<IActionResult> Index(int userId)
        {
            //string username = HttpContext.Session.GetString("username");
            int? userIdd = HttpContext.Session.GetInt32("Id");

            var toplam = 0;
            //var a = await _sepetService.SepetGetAll();
            var a = await _sepetService.SepetGetAllUser(userIdd);
            var b = await _adminService.GetByUser(userIdd);
            foreach (var item in a)
            {
                toplam += item.SepetPrice * item.SepetQuantity;
            }
            ViewBag.toplam = toplam;
            ViewBag.emailconfirm = b.emailconfirm;
            return View(a);

            
        }
        public async Task<IActionResult> SepetEkle(ProductWithStore data)
        {
            string b = HttpContext.Session.GetString("username");
            string c = HttpContext.Session.GetString("password");
            //var c = HttpContext.Session.GetString("Id");
            //var x = await _adminService.AdminFindUser(b,c);

            int? id = HttpContext.Session.GetInt32("Id");
            //string? id = HttpContext.Session.GetString("Id").ToString();
            //int d =Convert.ToInt32(c);
            //var result = Int32.Parse(b);
            var a = await _sepetService.SepetGetAll();
            foreach (var item in a)
            {
                if (item.Id == data.Id && item.userId == id)
                {
                    //data.Quantity = data.Quantity + 1;
                    //await _sepetService.SepetUpdate(new SepetModel() { Id = data.Id, SepetName = data.Name, SepetQuantity = data.Quantity , SepetPrice = data.Price, SepetImgUrl = data.ImageUrl, SepetDescription = data.Description });
                    return RedirectToAction("Index");
                }
            }
            await _sepetService.SepetInsert(new SepetModel()
            {
                Id = data.Id,
                SepetName = data.Name,
                SepetQuantity = 1,
                SepetPrice = data.Price,
                SepetImgUrl = data.ImageUrl,
                SepetDescription = data.Description,
                userId = id
            });
            return RedirectToAction("Index", id);
        }
        //[HttpPost]
        public async Task<IActionResult> UpdateQuantity(SepetModel data)
        {
            await _productService.ProductQuantity(new GelenData()
            {
                Id = data.Id,
                Quantity = data.SepetQuantity
            });
            await _sepetService.SepetUpdate(new SepetModel()
            {
                Id = data.Id,
                SepetName = data.SepetName,
                SepetQuantity = data.SepetQuantity,
                SepetPrice = data.SepetPrice,
                SepetImgUrl = data.SepetImgUrl,
                SepetDescription = data.SepetDescription
            });
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateQuantityOto(SepetModel data)
        {
            await _sepetService.SepetUpdate(new SepetModel()
            {
                Id = data.Id,
                SepetName = data.SepetName,
                SepetQuantity = data.SepetQuantity,
                SepetPrice = data.SepetPrice,
                SepetImgUrl = data.SepetImgUrl,
                SepetDescription = data.SepetDescription,
                userId = data.userId
            });
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSepet(int SepetId)
        {
            string b = HttpContext.Session.GetString("username");
            int? userIdd = HttpContext.Session.GetInt32("Id");
            //var a = await _sepetService.SepetGetById(SepetId);

            if (SepetId > 0 /*a.userId==b*/)
            {
                await _sepetService.SepetDeleteUser(SepetId, userIdd);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteSepetOto(SepetModel sepetModel)
        {
            var SepetId = sepetModel.Id;
            string b = HttpContext.Session.GetString("username");
            int? userIdd = HttpContext.Session.GetInt32("Id");
            if (SepetId > 0)
            {
                await _sepetService.SepetDeleteUser(SepetId, userIdd);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> HepsiniAl()
        {
            var a = await _sepetService.SepetGetAll();
            var b = await _productService.ProductGetAll();

            //int row=0;
            foreach (var item in b)
            {
                foreach (var x in a)
                {
                    if (item.Id == x.Id)
                    {
                        item.Quantity = item.Quantity - x.SepetQuantity;
                        await _productService.ProductQuantity(new GelenData()
                        {
                            Id = item.Id,
                            Quantity = x.SepetQuantity
                        });
                        await _sepetService.SepetDelete(x.Id);
                    }
                }
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> HepsiniAlUser(Email email, int userId)
        {
            var a = await _sepetService.SepetGetAllUser(userId);
            var b = await _productService.ProductGetAll();
            var c = await _adminService.GetByUser(userId);
            //int row=0;
            foreach (var item in b)
            {
                foreach (var x in a)
                {
                    if (item.Id == x.Id)
                    {
                        item.Quantity = item.Quantity - x.SepetQuantity;
                        await _productService.ProductQuantity(new GelenData()
                        {
                            Id = item.Id,
                            Quantity = x.SepetQuantity
                        });
                        await _sepetService.SepetDeleteUser(x.Id, userId);

                        if (c.emailconfirm == true)
                        {
                            string to = c.email;
                            string subject = "AA STORE Alışveriş Sitesi Bilgilendirme Mail'i ";
                            string body = x.SepetName + " ürününü " + x.SepetPrice + "₺ aldınız";
                            MailMessage mail = new MailMessage();
                            mail.To.Add(to);
                            mail.Subject = subject;
                            mail.Body = body;
                            mail.From = new MailAddress("");
                            mail.IsBodyHtml = false;
                            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                            smtpClient.Port = 587;
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.EnableSsl = true;
                            smtpClient.Credentials = new System.Net.NetworkCredential("", "");
                            smtpClient.Send(mail);
                            ViewBag.mesaj = "Mail " + mail.To + " adresine gönderildi";
                        }
                        else
                        {
                            //using (MailMessage mm = new MailMessage("", email.To))
                            //{
                            //    var c = await _adminService.GetByUser(userId);
                            //    mm.Subject = "Hesap Aktivasyonu";
                            //    string body = "Merhaba " + c.username + ",";
                            //    body += "<br /><br />Hesabınızı etkinleştirmek için lütfen aşağıdaki bağlantıyı tıklayın";
                            //    body += "<br /><a href = '" + string.Format("{0}://{1}/Home/Aktifet/{2}", /*Request.Url.Scheme, Request.Url.Authority,*/ c.emailconfirm) + "'>Hesabınızı etkinleştirmek için burayı tıklayın.</a>";
                            //    body += "<br /><br />Teşekkürler";
                            //    mm.Body = body;
                            //    mm.IsBodyHtml = true;
                            //    SmtpClient smtp = new SmtpClient();
                            //    smtp.Host = "smtp-mail.outlook.com";
                            //    smtp.EnableSsl = true;
                            //    NetworkCredential NetworkCred = new NetworkCredential("", "Mail adresine ait şifreniz");
                            //    smtp.UseDefaultCredentials = true;
                            //    smtp.Credentials = NetworkCred;
                            //    smtp.Port = 587;
                            //    smtp.Send(mm);
                            //    return View();
                            //}
                        }
                    }
                }
            }
            return RedirectToAction("Index", "Sepet");
        }
        public async Task<IActionResult> Arttir(int Id)
        {
            string b = HttpContext.Session.GetString("username");
            int? userIdd = HttpContext.Session.GetInt32("Id");
            var a = await _sepetService.SepetGetByIdUser(Id, userIdd);
            int x = a.SepetQuantity + 1;
            a.SepetQuantity = x;
            return RedirectToAction("UpdateQuantityOto", a);
        }
        public async Task<IActionResult> Azalt(int Id)
        {
            string b = HttpContext.Session.GetString("username");
            int? userIdd = HttpContext.Session.GetInt32("Id");
            var a = await _sepetService.SepetGetByIdUser(Id, userIdd);
            int temp = a.SepetQuantity - 1;
            a.SepetQuantity = temp;
            if (a.SepetQuantity == 0)
            {
                return RedirectToAction("DeleteSepetOto", a);
            }
            else
            {
                return RedirectToAction("UpdateQuantityOto", a);
            }
        }
    }
}
