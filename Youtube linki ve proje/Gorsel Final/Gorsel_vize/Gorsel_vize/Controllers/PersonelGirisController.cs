using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gorsel_vize.Models.Entity;

namespace Gorsel_vize.Controllers
{
    public class PersonelGirisController : Controller

        {
            private readonly dbo_ogrenciEntities db = new dbo_ogrenciEntities();
            public ActionResult Personel()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Personel(string kullaniciAdi, string sifre)
            {
                
                var personel = db.tbl_personel.FirstOrDefault(p => p.personelkulad == kullaniciAdi && p.personelsifre == sifre);

                if (personel != null)
                {
                    Session["Yetki"] = kullaniciAdi;
                    return RedirectToAction("Personel", "Personel");
                }
                else
                {
                    ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre!";
                    return View();
                }
            }
        }
    }

