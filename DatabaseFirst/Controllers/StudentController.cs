using DatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirst.Controllers
{
    public class StudentController : Controller
    {
        DatabaseFirstEntities db = new DatabaseFirstEntities();
        // GET: Student
        public ActionResult ViewDetails()
        { var data = db.Students;
            return View(data);
        }
        [HttpPost]
        public ActionResult Create(Student obj)
        {
            db.Students.Add(obj);
            int a=db.SaveChanges();
            if (a > 0)
            {
                TempData["MESSAGE"] = "Inserted successfully";
                return RedirectToAction("ViewDetails");
            }
            else {

                TempData["MESSAGE"] = "Cant inssert";
            }
            return View();
        }


    }
}