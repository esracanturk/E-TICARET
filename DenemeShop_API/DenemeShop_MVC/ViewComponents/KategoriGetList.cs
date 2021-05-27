using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DenemeShop_MVC.ViewComponents
{
    public class KategoriGetList : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ProductService service = new ProductService();
            var kategorilist = service.KategoriGetById(id);
            return View(kategorilist);
        }
    }
}
