using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DenemeShop_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using PagedList.Mvc;

namespace DenemeShop_MVC.ViewComponents
{
    public class FoodGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ProductService _productservice = new ProductService();
            //var foodlist = _productservice.ProductGetAll();
            var foodlist = _productservice.ProductGetAll();
            return View(foodlist);
        }
    }
}
