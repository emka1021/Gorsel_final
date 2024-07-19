using Gorsel_vize.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class BasvuruController : Controller
    {
        // GET: Basvuru
        dbo_ogrenciEntities db = new dbo_ogrenciEntities();

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult IsciBasvuru()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IsciBasvuru(tbl_ibas p1)
        {
            db.tbl_ibas.Add(p1);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult StajBasvuru()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StajBasvuru(tbl_sbas p1)
        {
            db.tbl_sbas.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}