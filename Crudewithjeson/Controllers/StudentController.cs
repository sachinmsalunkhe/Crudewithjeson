using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crudewithjeson.Models;

namespace Crudewithjeson.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        CollageDBEntities db = new CollageDBEntities();
        public ActionResult Index()
        {
            return View();

        }

        public JsonResult Getstudent()
        {
            return Json(db.Students.ToList(), JsonRequestBehavior.AllowGet);
        }
    
        public JsonResult Getstudentwithrno(int id)
        {
            Student st = db.Students.Find(id);
            return Json(st, JsonRequestBehavior.AllowGet);
        }
    
        public String Addstudent(Student st)
        {
            db.Students.Add(st);
            db.SaveChanges();
            return "student Add Successfully";
        }
    
    
    }



}