using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using DenemeShop_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace DenemeShop_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private IHostingEnvironment _environment;
        public ProductController(IProductService productService, IWebHostEnvironment webHostEnvironment, IHostingEnvironment environment)
        {
            _productService = productService;
            _webHostEnvironment = webHostEnvironment;
            _environment = environment;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> UserAnasayfa()
        {
            var a = await _productService.ProductGetAll();

            return View(a);

        }
        //[Authorize(Policy = "RequireAdministratorRole")]
        //[Authorize]
        public async Task<IActionResult> AdminAnasayfa(string foto)
        {
            //ViewData["FileLocation"] = foto;
            ViewBag.foto1 = foto;
            string b = HttpContext.Session.GetString("role");
            var a = await _productService.ProductGetAll();
            return View(a);
        }
        public async Task<IActionResult> SepetSayfa(ProductWithStore productWithStore)
        {
            //var a = await _productService.ProductGetAll();
            return View(productWithStore);
        }
        public async Task<IActionResult> Ekle(ProductWithStore productWith)
        {
            var degerler1 = await _productService.ProductGetAllStore();
            var degerler2 = await _productService.KategoriGetAll();
            ViewBag.deger2 = degerler2;
            ViewBag.deger1 = degerler1;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductEkle(GelenData gelenData, IFormFile file)
        {
            if (file != null || file.Length > 0)
            {
                var imagePath = @"\ProductImage\Image\";
                var uploadPath = _environment.WebRootPath + imagePath;

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                var fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                await _productService.ProductInsert(new GelenData
                {
                    /*Id = gelenData.Id,*/
                    Name = gelenData.Name,
                    Quantity = gelenData.Quantity,
                    Price = gelenData.Price,
                    ImageUrl = filePath,
                    Description = gelenData.Description,
                    groupId = gelenData.groupId,
                    KategoriID = gelenData.KategoriID
                });
                ViewData["FileLocation"] = filePath;
                var a = filePath;
                return RedirectToAction("AdminAnasayfa", "Product", a);
                //return View();
                //return RedirectToAction("Ekle","Product",filePath);
            }


            //if (file == null || file.Length == 0)
            //{
            //    return Content("dosya seçilemedi");
            //}

            //string path_Root = _environment.WebRootPath;
            //string path_to_Images = path_Root + "/ProductImage/Image/" + file.FileName;
            //using (var stream = new FileStream(path_to_Images, FileMode.Create))
            //{
            //    await file.CopyToAsync(stream);
            //}

            //ViewData["FilePath"] = path_to_Images;
            //return View();
            //await _productService.ProductInsert(new GelenData() { /*Id = gelenData.Id,*/ Name = gelenData.Name, Quantity = gelenData.Quantity, Price = gelenData.Price, ImageUrl = file.FileName, Description = gelenData.Description, groupId = gelenData.groupId, KategoriID = gelenData.KategoriID });
            //var a = await _productService.ProductGetAll();
            //return View();
            return RedirectToAction("Ekle");
            //return RedirectToAction("AdminAnasayfa", "Product");
        }

        public async Task<IActionResult> Update(int i)
        {
            var degerler1 = await _productService.ProductGetAllStore();
            var degerler2 = await _productService.KategoriGetAll();
            ViewBag.deger2 = degerler2;
            ViewBag.deger1 = degerler1;
            var a = await _productService.ProductGetById(i);
            return View(a);

        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(GelenData gelendata, IFormFile file)
        {
            var Id = gelendata.Id;
            if (file != null && file.Length > 0)
            {
                var imagePath = @"\ProductImage\Image\";
                var uploadPath = _environment.WebRootPath + imagePath;

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                var fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                await _productService.ProductUpdate(Id,new GelenData()
                {
                    //Id = gelendata.Id,
                    Name = gelendata.Name,
                    Quantity = gelendata.Quantity,
                    Price = gelendata.Price,
                    ImageUrl = filePath,
                    Description = gelendata.Description,
                    groupId = gelendata.groupId,
                    KategoriID = gelendata.KategoriID
                });
                ViewData["FileLocation"] = filePath;
                var a = filePath;
                return RedirectToAction("AdminAnasayfa", "Product", a);
            }
            
            return RedirectToAction("AdminAnasayfa", "Product");
        }

        public async Task<IActionResult> Buy(int i)
        {
            var a = await _productService.ProductGetById(i);
            return View(a);
        }
        [HttpGet]
        public async Task<IActionResult> Buy()
        {
            var a = await _productService.ProductGetAll();
            return View(a);
        }
        [HttpPost]
        public async Task<IActionResult> SepetBuy(ProductWithStore productWithStore)
        {
            //var a = await _productService.ProductGetAll();
            return RedirectToAction("DetaySepetBuy", productWithStore.Id);
        }
        public async Task<IActionResult> Detay(int i)
        {
            var a = await _productService.ProductGetById(i);
            //var a1 = await _productService.ProductGetAll();
            return View(a);
        }
        public async Task<IActionResult> DetaySepetBuy(int i)
        {
            var a = await _productService.ProductGetById(i);
            //var a1 = await _productService.ProductGetAll();
            return RedirectToAction("SepetEkle", "Sepet", a);
        }
        public async Task<IActionResult> ProductBuy(int id, int quantity)
        {
            await _productService.ProductBuy(id, quantity);
            //return RedirectToAction("AdminAnasayfa");
            return RedirectToAction("UserAnasayfa");
        }
        public async Task<IActionResult> Sil(int i)
        {
            await _productService.ProductDelete(i);
            return RedirectToAction("AdminAnasayfa");
        }
        public async Task<IActionResult> SilBitenProduct(int i)
        {
            await _productService.ProductDelete(i);
            return RedirectToAction("UserAnasayfa");
            //return RedirectToAction("ProductSil",i);
        }
    }
}
