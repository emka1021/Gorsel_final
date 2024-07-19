using Gorsel_vize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class MudurBasvuruController : Controller
    {
        // GET: MudurBasvuru
        dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Sbas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sbas(tbl_stajyer p1)
        {
            db.tbl_stajyer.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Ibas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ibas(tbl_ogretmenler p1)
        {
            db.tbl_ogretmenler.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}