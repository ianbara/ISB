﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace ISB.Website.ViewModels.DocTypes.Base
{
    public class Content : PublishedContentModel
    {
        public Content(IPublishedContent content)
            : base(content)
        {
        }
    }
}