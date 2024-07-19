using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class IsciController : Controller
    {
        // GET: Isci
        public ActionResult Index()
        {
            return View();
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