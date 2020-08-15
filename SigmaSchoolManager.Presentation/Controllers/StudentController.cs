using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SigmaSchoolManager.Application.Interfaces;
using SigmaSchoolManager.Application.ViewModels;

namespace SigmaSchoolManager.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            StudentViewModel model = _studentService.GetStudents();
            return View(model);
        }
    }
}