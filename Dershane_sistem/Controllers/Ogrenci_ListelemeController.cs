using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;

namespace Dershane_sistem.Controllers
{
    public class Ogrenci_ListelemeController : Controller
    {

        mustafaEntities2 db = new mustafaEntities2();
        [Authorize(Roles = "A")]
        public ActionResult Index()
        {
            //var degereler = db.Ogrenci.ToList();
            var degereler = db.Ogrenci.ToList();
            return View(degereler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {

            List<SelectListItem> degerler = (from i in db.Alanlar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.AlanAd,
                                                 Value = i.Alanid.ToString()
                                             }
                                             ).ToList();
            ViewBag.dgr = degerler;

            List<SelectListItem> degerler2 = (from a in db.Siniflar.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = a.SinifNo,
                                                  Value = a.Sinifid.ToString()
                                              }
                                           ).ToList();
            ViewBag.dgr1 = degerler2;

            return View();

        }
        [HttpPost]
        public ActionResult YeniOgrenci(Ogrenci p1)
        {
            var ogr = db.Alanlar.Where(m => m.Alanid == p1.Alanlar.Alanid).FirstOrDefault();
            p1.Alanlar = ogr;
            var ogr1 = db.Siniflar.Where(m => m.Sinifid == p1.Siniflar.Sinifid).FirstOrDefault();
            p1.Siniflar = ogr1;
            db.Ogrenci.Add(p1);


            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult SIL(int id)
        {
            var ogrsil = db.Ogrenci.Find(id);
            db.Ogrenci.Remove(ogrsil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult guncelleme_getir(int id)
        {
            var ogr = db.Ogrenci.Find(id);
            return View("guncelleme_getir", ogr);
        }
        public ActionResult Guncelle(Ogrenci p1)
        {
            var ogr = db.Ogrenci.Find(p1.Ogrid);
            ogr.OgrAd = p1.OgrAd;
            ogr.OgrSoyad = p1.OgrSoyad;
            ogr.OgrTc = p1.OgrTc;
            ogr.OgrTelefon = p1.OgrTelefon;
            ogr.OgrDogum = p1.OgrDogum;
            ogr.OgrAlanid = p1.OgrAlanid;
            ogr.OgrMail = p1.OgrMail;
            ogr.OgrVeliAdSoyad = p1.OgrVeliAdSoyad;
            ogr.OgrVeliTelefon = p1.OgrVeliTelefon;
            ogr.OgrVeliAdres = p1.OgrVeliAdres;
          
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    

      



    }
}