using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gorsel_vize.Controllers
{
    public class MudurgirisController : Controller
    {
        

            public ActionResult Giris()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Giris(FormCollection fc)
            {
                string kullaniciAdi = fc["kullaniciAdi"];
                string sifre = fc["sifre"];

                
                if (kullaniciAdi == "Ayşe" && sifre == "123456")
                {
                    Session["Yetki"] = kullaniciAdi;
                    return RedirectToAction("OgrenciBilgi", "MudurOgrenci");
                }
                else
                {
                    ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre!";
                    return View();
                }
            }

            public ActionResult Index()
            {
                
                if (Session["Yetki"] != null)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Giris");
                }
            }

           
        }
    

}