using Depratman_MVC.DepartmanPersonelModel;
using Depratman_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Depratman_MVC.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel

        PersonelDBEntities db = new PersonelDBEntities();
        public ActionResult Index()
        {
            var model = db.Personels.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult NewPerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewPerson(Personel person)
        {
            if (ModelState.IsValid)
            {
               db.Personels.Add(person);
               db.SaveChanges();
            }
            else
            {
                var dondur = ModelState.ToList();
            }


      
            return RedirectToAction("Index");
        }
    }
}