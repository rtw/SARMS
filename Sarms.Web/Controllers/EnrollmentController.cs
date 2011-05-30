using System.Data;
using System.Linq;
using System.Web.Mvc;
using Sarms.Domain.Core;
using Sarms.Domain.Data;

namespace Sarms.Web.Controllers
{ 
    public class EnrollmentController : Controller
    {
        private SarmsContext db = new SarmsContext();

        //
        // GET: /Enrollment/

        public ViewResult Index()
        {   
            var list = db.Enrollments.ToList();
            
            return View(db.Enrollments.ToList());
        }

        //
        // GET: /Enrollment/Details/5

        public ViewResult Details(int id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            return View(enrollment);
        }

        //
        // GET: /Enrollment/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Enrollment/Create

        [HttpPost]
        public ActionResult Create(string username, string unitname)
        {
            if (ModelState.IsValid)
            {
                var unit = db.Units.First(x => x.UnitName == unitname);
                var student = db.Students.First(x => x.Username == username);

                var enrollment = unit.EnrollStudent(student);

                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                
                return RedirectToAction("Index");  
            }

            return View();
        }
        
        //
        // GET: /Enrollment/Edit/5
 
        public ActionResult Edit(int id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            return View(enrollment);
        }

        //
        // POST: /Enrollment/Edit/5

        [HttpPost]
        public ActionResult Edit(Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enrollment);
        }

        //
        // GET: /Enrollment/Delete/5
 
        public ActionResult Delete(int id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            return View(enrollment);
        }

        //
        // POST: /Enrollment/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Enrollment enrollment = db.Enrollments.Find(id);
            db.Enrollments.Remove(enrollment);
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