using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Student;

namespace quanlyStudent.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices studentServices;
        public StudentController(IStudentServices studentServices)
        {
            this.studentServices = studentServices;
        }
        public IActionResult Index()
        {
            //var id = studentServices.getStudents(1);
            //return View(id);
            var students = studentServices.getList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            var create = studentServices.createList(student);
            TempData["msg"] = "Create Success";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var showEdit = studentServices.showEdit(id);
            return View(showEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            var edit = studentServices.editList(student);
            TempData["msg"] = "Update Success";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var timid = studentServices.deleteList(id);
            TempData["msg"] = "Delete Success";
            return RedirectToAction("Index");
        }
    }
}
