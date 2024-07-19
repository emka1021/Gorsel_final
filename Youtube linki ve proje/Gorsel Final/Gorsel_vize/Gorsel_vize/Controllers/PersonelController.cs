using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gorsel_vize.Models.Entity;

namespace Gorsel_vize.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            var degerler = db.tbl_personel.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(tbl_personel p1)
        {
            db.tbl_personel.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult SIL(int id)
        {
            var sil = db.tbl_personel.Find(id);
            db.tbl_personel.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Guncelle(int id)
        {
            var guncelle = db.tbl_personel.Find(id);
            return View("Guncelle", guncelle);
        }
        public ActionResult Guncelle1(tbl_personel p1)
        {
            var gnc = db.tbl_personel.Find(p1.personelid);
            gnc.personelad = p1.personelad;
            gnc.personelkulad = p1.personelkulad;
            gnc.personelsifre = p1.personelsifre;




            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}