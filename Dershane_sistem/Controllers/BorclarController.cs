using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;
namespace Dershane_sistem.Controllers
{
    public class BorclarController : Controller
    {
        // GET: Borclar
        mustafaEntities2 db = new mustafaEntities2();
        public ActionResult Index(string p)
        {
            var degerler = from d in db.Borclarr select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(x => x.OgrAd.Contains(p));
            }
            return View(degerler.ToList());
          //  var degereler = db.Borclarr.ToList();
            //return View(degereler);
            

        }
        [HttpGet]
        public ActionResult yeni_borc()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeni_borc(Borclarr p1)
        {
            db.Borclarr.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult SIL(int id)
        {
            var kategori = db.Borclarr.Find(id);
            db.Borclarr.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult borc_getir(int id)
        {
            var borc = db.Borclarr.Find(id);
            return View("borc_getir", borc);

        }
        public ActionResult Guncelle(Borclarr p1)
        {
            var personel = db.Borclarr.Find(p1.Ogrid);
            personel.OgrAd = p1.OgrAd;
            personel.OgrSoyad = p1.OgrSoyad;
            personel.OgrKalanBorc = p1.OgrKalanBorc;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}