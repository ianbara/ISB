using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISB.Website.Models
{
    public class TopNavigation
    {
        public TopNavigation()
        {
            NavigationItems = new List<NavigationItem>();
        }

        public bool ExtraPageInTopNavigation { get; set; }
        public List<NavigationItem> NavigationItems { get; set; }
        public NavigationItem ExtraNavigationItem { get; set; }
        public bool HasExtraNavigationItem { get { return ExtraNavigationItem != null; } }

    }
}