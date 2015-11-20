using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Archetype.Models;
using ISB.Website.Models.Archetype;
using ISB.Website.TypeConverters;
using ISB.Website.ViewModels.DocTypes.Base;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace ISB.Website.ViewModels.DocTypes
{
    [TypeConverter(typeof(DittoPickerConverter))]
    public class ContactUs : BasePage
    {
        public ContactUs(IPublishedContent content) : base(content)
        {
        }

        public string BodyText { get; set; }

    }
}