using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISB.Website.ViewModels;
using ISB.Website.ViewModels.DocTypes;
using Our.Umbraco.Ditto;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using ISB.Website.ViewModels.DocTypes.Base;

namespace ISB.Website.Controllers
{
    public class ArticlesController : RenderMvcController
    {
        // GET: Article
        public ActionResult Index(RenderModel model)
        {
            var viewModel = new ViewModel<Article>
            {
                Content = model.As<Article>()
            };

           return CurrentTemplate(viewModel);

        }
    }
}