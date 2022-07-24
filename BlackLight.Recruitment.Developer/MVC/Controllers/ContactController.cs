using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackLight.Recruitment.MVC.Models;

namespace BlackLight.Recruitment.MVC.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public ActionResult Submit(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["Name"] = model.Name;
                return RedirectToAction(nameof(HomeController.Thanks), "Home");
            }
            return View(model);
        }
    }
}