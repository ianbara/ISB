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
    public class HomePage : BasePage
    {
        public HomePage(IPublishedContent content)
            : base(content)
        {
            // ContentCollection = new List<ArchetypeFieldsetModel>();
        }

        // [ArchetypeResolver]
        public Header Header { get; set; }

        public string IntroText { get; set; }

        public string BodyText { get; set; }

        public Image Image { get; set; }

 

        //[TypeConverter(typeof(MultiNodeTreePickerConverter<IPublishedContent>))]
        //public IEnumerable<IPublishedContent> Articles { get; set; }


        // It is recommended to use lazy loading when referencing other IPublishedContent instances.

        [TypeConverter(typeof(DittoPickerConverter))]
        public virtual IEnumerable<IPublishedContent> FeaturedArticles { get; set; }


        //  [ArchetypeResolver]
        // public List<ArchetypeFieldsetModel> ContentCollection { get; set; }

        //[ArchetypeResolver]
        // public ContactOptions FooterGetInTouch { get; set; }

        public int DoNotIndexPage { get; set; }


    }
}