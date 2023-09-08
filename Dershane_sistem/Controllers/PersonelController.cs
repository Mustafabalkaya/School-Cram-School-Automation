using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;
namespace Dershane_sistem.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        
        mustafaEntities2 db = new mustafaEntities2();
        public ActionResult Index()
        {
            var degereler = db.Personel.ToList();
            return View(degereler);
        }
        [HttpGet]
        public ActionResult YeniPersonel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniPersonel(Personel p1)
        {
            db.Personel.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");



        }
        public ActionResult SIL(int id)
        {
            var kategori = db.Personel.Find(id);
            db.Personel.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult personel_getir(int id)
        {
            var personel = db.Personel.Find(id);
            return View("personel_getir", personel);

        }
        public ActionResult Guncelle(Personel p1)
        {
            var personel = db.Personel.Find(p1.Personelid);
            personel.PersonelAdSoyad = p1.PersonelAdSoyad;
            personel.PersonelDepartman = p1.PersonelDepartman;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}