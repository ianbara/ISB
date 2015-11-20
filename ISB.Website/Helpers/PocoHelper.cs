using System;
using System.Reflection;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace ISB.Website.Helpers
{
    public static class PocoHelper
    {
        public static T As<T>(this IPublishedContent content)
        {

            // Create an empty instance of the POCO
            var poco = Activator.CreateInstance<T>();

            // Discover properties of the poco with reflection
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var pocoType = poco.GetType();

            foreach (PropertyInfo propertyInfo in properties)
            {
                var contentType = content.GetType();
                if (content.GetType().GetProperty(propertyInfo.Name) != null)
                {
                    // It is a default propery - get the value with refelection
                    var propertyValue = contentType.GetProperty(propertyInfo.Name).GetValue(content, null);
                    pocoType.GetProperty(propertyInfo.Name).SetValue(poco, propertyValue, null);
                }
                else
                {
                    // it is a doctype property - ask Umbraco for the value
                    var propertyValue = content.GetPropertyValue(propertyInfo.Name);
                    pocoType.GetProperty(propertyInfo.Name).SetValue(poco, propertyValue, null);
                }
            }

            return poco;
        }
    }
}