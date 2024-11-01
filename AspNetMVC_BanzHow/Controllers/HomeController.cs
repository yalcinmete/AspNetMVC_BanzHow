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
            model.UrunSayisi = Veritabanı.Liste.Where(i => i.Satistami == true).Count();
            model.Urunler = Veritabanı.Liste.Where(i=>i.Satistami == true ).ToList();

            return View(model);
            
        }

        public ActionResult Details(int id)
        {
            var urun = Veritabanı.Liste.Where(i=>i.UrunId==id).FirstOrDefault();

            return View(urun);
        }


        public ActionResult UrunEkle()
        {
            return View();
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