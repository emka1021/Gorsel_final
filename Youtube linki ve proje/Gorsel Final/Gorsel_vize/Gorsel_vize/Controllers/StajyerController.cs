using Gorsel_vize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class StajyerController : Controller
    {
        dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        // GET: Stajyer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Guncelle(int id)
        {
            var guncelle = db.tbl_ogretmenler.Find(id);
            return View("Guncelle", guncelle);
        }
        public ActionResult Rapor()
        {
            return View();
        }
        public ActionResult MezunEt()
        {
            var mezunOgrenciler = db.tbl_ogrenci.Where(o => o.okredi >= 2).ToList();

            foreach (var ogrenci in mezunOgrenciler)
            {
                if (ogrenci.okredi >= 2)
                {
                    ogrenci.odurum = "Mezun";
                }
                else
                {
                    ViewBag.ErrorMessage = "Öğrencinin kredi notu 2'den düşük olduğu için mezun edilemez!";
                    return View();
                }
            }

            db.SaveChanges();

            return RedirectToAction("Index", "Stajyer");
        }
        [HttpGet]
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index1(FormCollection collection)
        {
            // Kaydetme işlemleri burada yapılabilir
            return RedirectToAction("Index");
        }
    }

}