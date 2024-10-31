using AspNetMVC_BanzHow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_BanzHow.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult KategoriMenu()
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){Id=1,KategoriAdi="Telefon"},
                new Kategori(){Id=1,KategoriAdi="Tablet"},
                new Kategori(){Id=1,KategoriAdi="Laptop"}
            };

            return PartialView("KategoriMenu", kategoriler);
        }
    }
}