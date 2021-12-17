using Microsoft.AspNetCore.Mvc;
using MySD1ManagementSystemStudentPortalWeb.Services.Reporitory.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySD1ManagementSystemStudentPortalWeb.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentMockRepository _studentMockRepository;

        public StudentsController(IStudentMockRepository studentMockRepository)
        {
            _studentMockRepository = studentMockRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _studentMockRepository.GetAllStudents();
            return View("list", model);
        }

        //[HttpGet]
        //public IActionResult UpsertStudent(int? id)
        //{
        //    if(id == null)
        //    {

        //    }
        //}

    }
}
