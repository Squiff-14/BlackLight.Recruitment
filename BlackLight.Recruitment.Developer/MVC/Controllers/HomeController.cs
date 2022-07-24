using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackLight.Recruitment.MVC.Models;

namespace BlackLight.Recruitment.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new ContactUsViewModel());
        }

        public ActionResult Thanks()
        {
            var model = new ThanksViewModel
            {
                Name = (string)TempData["Name"]
            };
            return View(model);
        }
	}
}