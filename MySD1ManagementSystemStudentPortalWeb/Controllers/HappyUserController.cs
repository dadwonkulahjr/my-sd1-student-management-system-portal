using Microsoft.AspNetCore.Mvc;
using MySD1ManagementSystemStudentPortalWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySD1ManagementSystemStudentPortalWeb.Controllers
{
    public class HappyUserController : Controller
    {
        [HttpPost]
        public IActionResult UserConfirmation(HappyUserViewModel model)
        {
            return View();
        }
    }
}
