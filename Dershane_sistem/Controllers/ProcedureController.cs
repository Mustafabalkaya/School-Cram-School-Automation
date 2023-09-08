using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;
namespace Dershane_sistem.Controllers
{
    public class ProcedureController : Controller
    {
        // GET: Procedure
        mustafaEntities2 db = new mustafaEntities2();
        [AllowAnonymous]
        public ActionResult Index(string a) //SAYISAL
        {
            a = "1";
            List<musti_Result> m = db.musti(a).ToList();
            return View(m);
        }
        public ActionResult Sozel(string a) //SÖZEL
        {
            a = "2";
            List<musti_Result> m = db.musti(a).ToList();
            return View(m);
        }
        public ActionResult EsitAgirlik(string a) //EŞİTAĞIRLIK
        {
            a = "3";
            List<musti_Result> m = db.musti(a).ToList();
            return View(m);
        }
        public ActionResult Dil(string a) //DİL
        {
            a = "4";
            List<musti_Result> m = db.musti(a).ToList();
            return View(m);
        }
        public ActionResult Diger(string a) //DİĞER
        {
            a = "1";
            List<musti_Result> m = db.musti(a).ToList();
            return View(m);
        }
    }
}