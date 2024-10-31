﻿using AspNetMVC_BanzHow.Models;
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

            List<Urun> urunler = new List<Urun>()
            {
                new Urun(){UrunId=1,UrunAdi="Samsung S6",Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",Fiyat=1000,Satistami=true},
                new Urun(){UrunId=2,UrunAdi="Samsung S7",Aciklama="İdare eder",Fiyat=1000,Satistami=false},
                new Urun(){UrunId=3,UrunAdi="Samsung S8",Aciklama="İdare eder",Fiyat=2000,Satistami=true},
                new Urun(){UrunId=4,UrunAdi="Iphone 6S",Aciklama="İdare eder",Fiyat=3000,Satistami=false},
                new Urun(){UrunId=5,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=true},
                new Urun(){UrunId=6,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=false},
                new Urun(){UrunId=7,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=true},
                new Urun(){UrunId=8,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=true},
                new Urun(){UrunId=9,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=false}
            };



            UrunKategoriModel model = new UrunKategoriModel();
            model.UrunSayisi = urunler.Count();
            model.Urunler = urunler;


            //ViewBag.UrunSayisi = urunler.Count();
            //ViewBag.Kategoriler = kategoriler;

            //return View(urunler);
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