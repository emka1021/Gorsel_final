using Gorsel_vize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class IsciGirisController : Controller
    {
        // GET: IsciGiris
        private readonly dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string kullaniciAdi, string sifre)
        {
            var ibas = db.tbl_ibas.FirstOrDefault(p => p.ibas_kulad == kullaniciAdi && p.ibas_sifre == sifre);

            if (ibas != null)
            {
                Session["Yetki"] = kullaniciAdi;
                return RedirectToAction("Index", "Isci");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre!";
                return View();
            }
        }
    }
}