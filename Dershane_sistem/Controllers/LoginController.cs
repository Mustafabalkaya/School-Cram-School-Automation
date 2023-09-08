using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using Dershane_sistem.Models.Entity;

namespace Dershane_sistem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        mustafaEntities2 db = new mustafaEntities2();
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(Admin a)
        {
            var bilgiler = db.Admin.FirstOrDefault(x => x.YoneticiAd == a.YoneticiAd && x.YoneticiSifre == a.YoneticiSifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.YoneticiAd, false);
                Session["YoneticiAd"] = bilgiler.YoneticiAd;
                return RedirectToAction("Index","Ogrenci_Listeleme");
            }
            else
            {

                return View();
            }
            

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Giris","Login");
        }
        
    }
}