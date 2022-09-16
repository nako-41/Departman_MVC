using Depratman_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Depratman_MVC.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        PersonelDBEntities db = new PersonelDBEntities();
        public ActionResult Index()
        {
          
            var model = db.Departmen.ToList();
         
            return View(model);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Departman departman)
        {
            db.Departmen.Add(departman);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var dep = db.Departmen.Find(id);
            db.Departmen.Remove(dep);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpPost]
         public ActionResult DepartGetir(int id)
        {
            var dtp = db.Departmen.Find(id);
            db.SaveChanges();
            return View("DepartGetir");
        }




    }
}