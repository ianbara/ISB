using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace ISB.Website.ViewModels.DocTypes.Base
{
    public class BasePage : Content
    {

        public BasePage(IPublishedContent content)
            : base(content)
        {
        }

        public string PageTitle { get; set; }

        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }

    }
}