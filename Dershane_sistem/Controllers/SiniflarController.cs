using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;
namespace Dershane_sistem.Controllers
{
    public class SiniflarController : Controller
    {
        // GET: Siniflar
        mustafaEntities2 db = new mustafaEntities2();
        public ActionResult Index()
        {
            var deger = db.Siniflar.ToList();
            return View(deger);
        }
    }
}