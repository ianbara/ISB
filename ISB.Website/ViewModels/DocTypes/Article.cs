using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ISB.Website.ViewModels.DocTypes.Base;
using Our.Umbraco.Ditto;
using Umbraco.Core;
using Umbraco.Core.Models;
using umbraco.presentation.webservices;
using ISB.Website.ViewModels.DocTypes;

namespace ISB.Website.ViewModels
{
    [TypeConverter(typeof(DittoPickerConverter))]
    public class Article : BasePage
    {
        public Article(IPublishedContent content)
            : base(content)
        {
            // ContentCollection = new List<ArchetypeFieldsetModel>();
        }

        public string Title { get; set; }
        public string Summary { get; set; }
        public string BodyText { get; set; }
        public string Tags { get; set; }
        public string Template { get; set; }
        public Image Image { get; set; }
        public string SideBarText { get; set; }

        public List<string> TagsList
        {
            get
            {
                if (Tags != null)
                {
                    return Tags.Split(',').ToList();    
                }
                return new List<string>();

            }
        }

        public DateTime UpdateDate { get; set; }

        public virtual IEnumerable<Article> Children { get; set; }

        public IEnumerable<Article> FilteredArticlesByTag
        {
            get
            {
                string tagToFind = HttpContext.Current.Request.QueryString["tag"];
                //var allNodesWithTags = Model.AncestorOrSelf().DescendantsOrSelf().Where("tags != \"\"");
                if (Children.Any())
                {
                    if (!tagToFind.IsNullOrWhiteSpace())
                    {
                        return Children.Where(a => a.Tags.Contains(tagToFind));    
                    }

                    return Children;
                }

                return null;

            }
        }

    }
}