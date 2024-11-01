using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC_BanzHow.Models
{
    public static class Veritabanı
    {
        private static List<Urun> _liste;

        static Veritabanı() 
        {
            _liste = new List<Urun>()
            {

                new Urun(){UrunId=1,UrunAdi="Samsung S6",Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",Fiyat=1000,Satistami=true,Resim = "1.jpg"},
                new Urun(){UrunId=2,UrunAdi="Samsung S7",Aciklama="İdare eder",Fiyat=1000,Satistami=false,Resim = "2.jpg"},
                new Urun(){UrunId=3,UrunAdi="Samsung S8",Aciklama="İdare eder",Fiyat=2000,Satistami=true,Resim = "3.jpg"},
                new Urun(){UrunId=4,UrunAdi="Iphone 6S",Aciklama="İdare eder",Fiyat=3000,Satistami=false,Resim = "4.jpg"},
                new Urun(){UrunId=5,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=true,Resim = "1.jpg"},
                new Urun(){UrunId=6,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=false,Resim = "2.jpg"},
                new Urun(){UrunId=7,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=true,Resim = "3.jpg"},
                new Urun(){UrunId=8,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=true,Resim = "4.jpg"},
                new Urun(){UrunId=9,UrunAdi="Iphone 7S",Aciklama="İdare eder",Fiyat=3000,Satistami=false,Resim = "1.jpg"}
            };
        }



        public static List<Urun> Liste //Metot değil bir property değişken
        {
            get { return _liste; }
        }

        public static void ElemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }

        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (Urun urun in _liste)
            {
                if (urun.UrunId == urunid)
                {
                    entity = urun;
                }
            }
            return entity;
        }
    }
}