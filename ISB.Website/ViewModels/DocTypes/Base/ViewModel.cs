using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISB.Website.ViewModels.DocTypes.Base
{
    public class ViewModel<T> where T : Content
    {
        public T Content { get; set; }
    }
}