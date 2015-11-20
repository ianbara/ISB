using System.Collections.Generic;

namespace ISB.Website.Models
{
    public class NavigationItem
    {
        public NavigationItem()
        {
            SubNavigationItems = new List<NavigationItem>();
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public string NewWindow { get; set; }
        public bool ActiveParent { get; set; }
        public bool Current { get; set; }
        public bool HideFromSiteMap { get; set; }
        public string CurrentCssClass { get { return Current ? "current" : ""; } }
        public string ActiveCssClass { get { return ActiveParent ? "active-parent" : ""; } }
        public List<NavigationItem> SubNavigationItems { get; set; }
    }
}