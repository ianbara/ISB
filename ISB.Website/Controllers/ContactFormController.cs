using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using ISB.Website.ViewModels;
using Umbraco.Web.Mvc;

namespace ISB.Website.Controllers
{
    public class ContactFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult ContactForm(ContactForm model)
        {
            //model not valid, do not save, but return current Umbraco page
            if (!ModelState.IsValid)
            {
                //Perhaps you might want to add a custom message to the ViewBag
                //which will be available on the View when it renders (since we're not 
                //redirecting)          
                return CurrentUmbracoPage();
            }

            //Add a message in TempData which will be available 
            //in the View after the redirect 
            ViewBag.SuccessMessage = "Your form was successfully submitted at " + DateTime.Now;

            //redirect to current page to clear the form
            return RedirectToCurrentUmbracoPage();
        }
    }
}