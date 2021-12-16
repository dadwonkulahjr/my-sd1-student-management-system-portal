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
            if (!ModelState.IsValid) { return View("index", model); }

            //Next is using the Required attribute for testing validations!
            return View("index", model);
        }
    }
}
