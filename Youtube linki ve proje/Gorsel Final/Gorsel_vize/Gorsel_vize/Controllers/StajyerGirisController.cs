using Gorsel_vize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class StajyerGirisController : Controller
    {
        private readonly dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string kullaniciAdi, string sifre)
        {
            var stajyer = db.tbl_sbas.FirstOrDefault(p => p.sbas_kulad == kullaniciAdi && p.sbas_sifre == sifre);

            if (stajyer != null)
            {
                Session["Yetki"] = kullaniciAdi;
                return RedirectToAction("Index", "Stajyer");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre!";
                return View();
            }
        }
    }
}
