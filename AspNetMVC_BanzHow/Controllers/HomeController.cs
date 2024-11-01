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

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult UrunEkle(string UrunAdi,string Aciklama,double Fiyat,string Resim,bool Satistami)
        public ActionResult UrunEkle(Urun entity)
        {
            //Urun entity = new Urun();
            //entity.UrunAdi = UrunAdi;
            //entity.Aciklama = Aciklama;
            //entity.Fiyat = Fiyat;
            //entity.Resim = Resim;
            //entity.Satistami = Satistami;
            Veritabanı.ElemanEkle(entity);
            return View("UrunListe",Veritabanı.Liste);
            //return View();
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