﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gorsel_vize.Models.Entity;

namespace Gorsel_vize.Controllers
{
    public class MudurIdareController : Controller
    {
        // GET: MudurIdare
        dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            var degerler = db.tbl_idare.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(tbl_idare p1)
        {
            db.tbl_idare.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var sil = db.tbl_idare.Find(id);
            db.tbl_idare.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Guncelle(int id)
        {
            var guncelle = db.tbl_idare.Find(id);
            return View("Guncelle", guncelle);
        }
        public ActionResult Guncelle1(tbl_idare p1)
        {
            var gnc = db.tbl_idare.Find(p1.pid);
            gnc.perad = p1.perad;
            gnc.perbolum = p1.perbolum;
            gnc.perbas = p1.perbas;



            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Stajyer()
        {
            return View();
        }
        public ActionResult Isci()
        {
            return View();
        }
    }
}