using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DenemeShop_MVC.ViewComponents
{
    public class ListKategori : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //soldaki kategori kısmı. KategoriGetAll
            ProductService productService = new ProductService();
            var kategorilist = productService.KategoriGetAll();
            return View(kategorilist);
        }
    }
}
