using Gorsel_vize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class MudurStajyerController : Controller
    {
        dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            var degerler = db.tbl_stajyer.ToList();
            return View(degerler); // Modeli view'e gönderiyoruz.
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(tbl_stajyer p1)
        {
            db.tbl_stajyer.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index"); // Ekleme sonrası Index sayfasına yönlendirme
        }

        public ActionResult SIL(int id)
        {
            var sil = db.tbl_stajyer.Find(id);
            db.tbl_stajyer.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Guncelle(int id)
        {
            var guncelle = db.tbl_stajyer.Find(id);
            return View("Guncelle", guncelle);
        }

        [HttpPost]
        public ActionResult Guncelle(tbl_stajyer p1)
        {
            var gnc = db.tbl_stajyer.Find(p1.sid);
            gnc.stajyer_ad = p1.stajyer_ad;
            gnc.stajyer_kullanıcıad = p1.stajyer_kullanıcıad;
            gnc.stajyer_sifre = p1.stajyer_sifre;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
