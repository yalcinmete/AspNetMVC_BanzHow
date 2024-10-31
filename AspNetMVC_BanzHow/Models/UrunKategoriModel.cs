using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVC_BanzHow.Models
{
    public class UrunKategoriModel
    {
        public int UrunSayisi { get; set; }
        public List<Urun> Urunler { get; set; }
        //public List<Kategori> Kategoriler { get; set; }
    }
}