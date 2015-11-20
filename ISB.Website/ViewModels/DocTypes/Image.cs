using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Our.Umbraco.Ditto;

namespace ISB.Website.ViewModels.DocTypes
{
    [TypeConverter(typeof(DittoMediaPickerConverter))]
    public class Image
    {
        public string Url { get; set; }

    }
}