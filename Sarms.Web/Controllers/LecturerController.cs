using System.Data;
using System.Linq;
using System.Web.Mvc;
using Sarms.Domain.Core;
using Sarms.Domain.Data;

namespace Sarms.Web.Controllers
{ 
    public class LecturerController : Controller
    {
        private SarmsContext db = new SarmsContext();

        //
        // GET: /Lecturer/

        public ViewResult Index()
        {
            return View(db.Lecturers.ToList());
        }

        //
        // GET: /Lecturer/Details/5

        public ViewResult Details(int id)
        {
            Lecturer lecturer = db.Lecturers.Find(id);
            return View(lecturer);
        }

        //
        // GET: /Lecturer/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Lecturer/Create

        [HttpPost]
        public ActionResult Create(Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                db.Lecturers.Add(lecturer);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(lecturer);
        }
        
        //
        // GET: /Lecturer/Edit/5
 
        public ActionResult Edit(int id)
        {
            Lecturer lecturer = db.Lecturers.Find(id);
            return View(lecturer);
        }

        //
        // POST: /Lecturer/Edit/5

        [HttpPost]
        public ActionResult Edit(Lecturer lecturer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lecturer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lecturer);
        }

        //
        // GET: /Lecturer/Delete/5
 
        public ActionResult Delete(int id)
        {
            Lecturer lecturer = db.Lecturers.Find(id);
            return View(lecturer);
        }

        //
        // POST: /Lecturer/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Lecturer lecturer = db.Lecturers.Find(id);
            db.Lecturers.Remove(lecturer);
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