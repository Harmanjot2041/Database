using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatabaseBO;
using DatabaseEntities.Entities;
using DatabaseEntities.CustomModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DatabaseAssignment.Controllers
{
    
    public class StudentController : Controller
    {

        private readonly IStudentComponent _studentComonent;
        public StudentController(IStudentComponent studentComonent)
        {
            _studentComonent = studentComonent;
        }
        // GET: Student

        public ActionResult Index()
        {
            return View(_studentComonent.GetStudents());
        }

        // GET: Student/Details
        public ActionResult Details(int id)
        {
            return View(_studentComonent.GetStudentById(id));
        }

        // GET: Student/Create
        public ActionResult Create()
        {
           
            ViewBag.Colleges = _studentComonent.GetCollege();
            ViewBag.Teachers = _studentComonent.GetTeacher();
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student model)
        {
            try
            {
                _studentComonent.InsertUpdateStudent(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit
        public ActionResult Edit(int id)
        {
            ViewBag.Colleges = _studentComonent.GetCollege();
            ViewBag.Teachers = _studentComonent.GetTeacher();
            return View(_studentComonent.GetStudentById(id));
        }

        // POST: Student/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student model)
        {
            try
            {

                model.StudentId = id;
                _studentComonent.InsertUpdateStudent(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete
        public ActionResult Delete(int id)
        {
            return View(_studentComonent.GetStudentById(id));
        }

        // POST: Student/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student model)
        {
            try
            {
                _studentComonent.DeleteStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Search(string Search)
        {
            
            return View("Index",_studentComonent.SearchStudents(Search));
        }

        public ActionResult Employee(int id)
        {
            
            if (id == 0)
                id = 1;
            ViewBag.PageNo = id;
            ViewBag.TotalPages = _studentComonent.TotalPages();
            
            return View(_studentComonent.Pagination(id));
        }
        [HttpPost]
        public ActionResult Sorting(String  Order)
        {
            if(Order == "Decending")
            {
                List<StudentCustom> temp = (from item in _studentComonent.GetStudents() orderby item.StudentId descending select item).ToList();
                return View("Index", temp);
            }
            return View("Index", _studentComonent.GetStudents());
        }
    }
}
