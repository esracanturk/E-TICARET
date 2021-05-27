using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Interfaces;
using DenemeShop_MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DenemeShop_MVC.Controllers
{
    public class ImageController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IAdminService _adminService;
        private IHostingEnvironment _environment;

        public ImageController(ILogger<HomeController> logger, IProductService productService, IAdminService adminService, IHostingEnvironment environment)
        {
            _logger = logger;
            _productService = productService;
            _adminService = adminService;
            _environment = environment;
        }
        [HttpGet]
        public IActionResult Upload_Image()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload_Image(IFormFile file)
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
                string fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                ViewData["FileLocation"] = filePath;
            }

            return View();



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
        }



    }
}
