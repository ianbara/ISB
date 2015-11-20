using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;


namespace ISB.Website.Models
{
    public class SiteNavigation
    {
        private readonly IPublishedContent _publishedContent;
        private IPublishedContent PublishedContent { get { return _publishedContent; } }

        private readonly IPublishedContent _currentPage;
        private IPublishedContent CurrentPage { get { return _currentPage; } }

        public TopNavigation TopNavigation { get; set; }

        public SiteNavigation()
        {
            UmbracoHelper umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            _publishedContent = umbracoHelper.TypedContentAtRoot().FirstOrDefault();

            // Check Current Page Id, if null (non umbraco page) default current page to root nome page.
            _currentPage = UmbracoContext.Current.PageId != null ? umbracoHelper.AssignedContentItem : _publishedContent;

            PopulateTopNavigation();

        }

        private void PopulateTopNavigation()
        {
            TopNavigation = new TopNavigation();

            foreach (var page in PublishedContent.Children.Where(x => x.GetPropertyValue<bool>("showInTopNavigation")))
            {
                TopNavigation.NavigationItems.Add(new NavigationItem()
                {
                    Name = page.Name,
                    Url = page.Url
                });
            }

        }
    }
}