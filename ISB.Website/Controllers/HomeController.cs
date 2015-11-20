using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISB.Website.Models;
using ISB.Website.ViewModels;
using ISB.Website.ViewModels.DocTypes;
using ISB.Website.ViewModels.DocTypes.Base;
using Our.Umbraco.Ditto;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace ISB.Website.Controllers
{
    public class HomeController : SurfaceController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

    
        public PartialViewResult SiteNavigation()
        {
            var model = new SiteNavigation();

            return PartialView("~/Views/Shared/_TopNavigation.cshtml", model);
        }

        public PartialViewResult ContactForm()
        {
            var model = new ContactForm();

            return PartialView("~/Views/Shared/_contactForm.cshtml", model);
        }

    }
}
