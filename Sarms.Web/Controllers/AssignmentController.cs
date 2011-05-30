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
    public class AssignmentController : Controller
    {
        private SarmsContext db = new SarmsContext();

        //
        // GET: /Assignment/

        public ViewResult Index()
        {
            return View(db.Assignments.ToList());
        }

        //
        // GET: /Assignment/Details/5

        public ViewResult Details(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            return View(assignment);
        }

        //
        // GET: /Assignment/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Assignment/Create

        [HttpPost]
        public ActionResult Create(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                db.Assignments.Add(assignment);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(assignment);
        }
        
        //
        // GET: /Assignment/Edit/5
 
        public ActionResult Edit(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            return View(assignment);
        }

        //
        // POST: /Assignment/Edit/5

        [HttpPost]
        public ActionResult Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assignment);
        }

        //
        // GET: /Assignment/Delete/5
 
        public ActionResult Delete(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            return View(assignment);
        }

        //
        // POST: /Assignment/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Assignment assignment = db.Assignments.Find(id);
            db.Assignments.Remove(assignment);
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