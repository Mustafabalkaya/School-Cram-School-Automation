using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;
namespace Dershane_sistem.Controllers
{
    public class GiderlerController : Controller
    {
        // GET: Giderler
        mustafaEntities2 db = new mustafaEntities2();
        [Authorize(Roles = "P")]
        public ActionResult Index()
        {
            var deger = db.Giderler.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult gider_ekleme()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Gider_Ekleme(Giderler p1)
        {
            db.Giderler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult SIL(int id)
        {
            var kategori = db.Giderler.Find(id);
            db.Giderler.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult giderleri_getir(int id)
        {
            var ogr = db.Giderler.Find(id);
            return View("gider_getir", ogr);
        }
        public ActionResult gider_Guncelle(Giderler p1)
        {
            var ogr = db.Giderler.Find(p1.Odemeid);
            ogr.Elektrik = p1.Elektrik;
            ogr.Su = p1.Su;
            ogr.Dogalgaz = p1.Dogalgaz;
            ogr.internet = p1.internet;
            ogr.Gida = p1.Gida;
            ogr.Personel = p1.Personel;
            ogr.Diger = p1.Diger;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}