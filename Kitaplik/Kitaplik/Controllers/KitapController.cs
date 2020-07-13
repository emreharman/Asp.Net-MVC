using Kitaplik.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kitaplik.Controllers
{
    public class KitapController : Controller
    {
        myDbContext db = new myDbContext();
        // GET: Kitap
        public ActionResult Index()
        {
            var kitaplar = db.Kitaps.ToList();
            return View(kitaplar);
        }
        public ActionResult KitapEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KitapEkle(Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                db.Kitaps.Add(kitap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }
        public ActionResult Guncelle(int id)
        {
            var kitap= db.Kitaps.Find(id);
            return View(kitap);
        }
        [HttpPost]
        public ActionResult Guncelle(Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kitap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kitap);
            
        }
        public ActionResult Sil(int id)
        {
            var kitap = db.Kitaps.Find(id);
            db.Kitaps.Remove(kitap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
      
    }
}