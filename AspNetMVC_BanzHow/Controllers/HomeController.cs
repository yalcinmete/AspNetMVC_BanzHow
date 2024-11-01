using AspNetMVC_BanzHow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_BanzHow.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        { 
            UrunKategoriModel model = new UrunKategoriModel();
            model.UrunSayisi = Veritabanı.Liste.Count();
            model.Urunler = Veritabanı.Liste;

            return View(model);
            
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About() 
        {
            return View();
        }
    }
}