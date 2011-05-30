using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sarms.Domain.Core;
using Sarms.Domain.Data;

namespace Sarms.Web.Controllers
{ 
    public class AdministratorController : Controller
    {
        private SarmsContext db = new SarmsContext();

        //
        // GET: /Adminstrator/

        public ViewResult Index()
        {
            return View(db.Administrators.ToList());
        }

        //
        // GET: /Adminstrator/Details/5

        public ViewResult Details(int id)
        {
            Administrator administrator = db.Administrators.Find(id);
            return View(administrator);
        }

        //
        // GET: /Adminstrator/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Adminstrator/Create

        [HttpPost]
        public ActionResult Create(Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                db.Administrators.Add(administrator);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(administrator);
        }
        
        //
        // GET: /Adminstrator/Edit/5
 
        public ActionResult Edit(int id)
        {
            Administrator administrator = db.Administrators.Find(id);
            return View(administrator);
        }

        //
        // POST: /Adminstrator/Edit/5

        [HttpPost]
        public ActionResult Edit(Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administrator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrator);
        }

        //
        // GET: /Adminstrator/Delete/5
 
        public ActionResult Delete(int id)
        {
            Administrator administrator = db.Administrators.Find(id);
            return View(administrator);
        }

        //
        // POST: /Adminstrator/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Administrator administrator = db.Administrators.Find(id);
            db.Administrators.Remove(administrator);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}