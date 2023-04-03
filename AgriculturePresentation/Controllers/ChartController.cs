using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();
            productClasses.Add(new ProductClass
            {
                productname = "ASP.Net Mvc Web Site",
                productvalue = 19999
            });
            productClasses.Add(new ProductClass
            {
                productname ="Masaüstü Otomasyon",
                productvalue =9999
            });
            productClasses.Add(new ProductClass
            {
                productname = "Android Uygulama",
                productvalue = 4999
            });
            productClasses.Add(new ProductClass
            {
                productname = "Proje Geliştirme",
                productvalue = 9999
            });
            return Json(new { jsonlist = productClasses });
        }
    }
}
