using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Archetype.Models;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace ISB.Website.Models.Archetype
{
    public class Header : ArchetypeFieldsetModel
    {
        private readonly IPublishedContent _publishedContent;
        private IPublishedContent PublishedContent { get { return _publishedContent; } }

        public bool ShowHeaderPanel { get; set; }
        public int ShowCalculator { get; set; }
        public string HeaderText { get; set; }
        private string _BodyText { get; set; }

        public string BodyText
        {
            get
            {
                return _BodyText;
            }
            set
            {
                if (value != null)
                {
                    _BodyText = Umbraco.Web.Templates.TemplateUtilities.ParseInternalLinks(value);
                }
                else
                {
                    _BodyText = string.Empty;
                }
            }
        }

        public bool ShowRepresentativeExample { get; set; }
        public bool ShowRiskStatement { get; set; }

        public bool HasRiskStatement { get { return RiskStatement != null; } }
        public string RiskStatement
        {
            get { return PublishedContent.GetPropertyValue<string>("riskStatement", true); }
        }

        //[ArchetypeResolver]
        //public KeyMessagePanel KeyMessagePanel { get; set; }

        public Header()
        {
            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            _publishedContent = umbracoHelper.TypedContentAtRoot().FirstOrDefault();

        }
    }
}