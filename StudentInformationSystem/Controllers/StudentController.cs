using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_BusinessLogicLayer;
using SIS_DataModelLayer;
using SIS_DataAccessLayer;
using System.Net;
using System.Data;

namespace EntityDemo.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(StudentModel studobj)
        {

            Services.InsertStudent(studobj);
            return View();

        }

        StudentInformationSystemEntities db = new StudentInformationSystemEntities();

        [HttpGet]

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModel stuobj = db.tblStudent.Find(id);
            if (stuobj == null)
            {
                return HttpNotFound();
            }
            return View(stuobj);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentModel studobj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studobj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studobj);
        }

        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentModel stuobj = db.tblStudent.Find(id);
            if (stuobj == null)
            {
                return HttpNotFound();
            }
            return View(stuobj);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentModel stuobj = db.tblStudent.Find(id);
            db.tblStudent.Remove(stuobj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
