﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using Umbraco.Core;
using Umbraco.Web;

namespace ISB.Website.TypeConverters
{
    public static class ConverterHelper
    {
        /// <summary>
        /// Gets the <see cref="UmbracoHelper"/> for querying published content or media.
        /// </summary>
        public static UmbracoHelper UmbracoHelper
        {
            get
            {
                // Pull the item from the cache if possible to reduce the db access overhead caused by 
                // multiple reflection iterations for the given type taking place in a single request.
                return (UmbracoHelper)ApplicationContext.Current.ApplicationCache.RequestCache.GetCacheItem(
                        "Ditto.UmbracoHelper",
                        () => new UmbracoHelper(UmbracoContext.Current));
            }
        }

        /// <summary>
        /// Gets Ids from known XML fragments (as saved by the MNTP / XPath CheckBoxList)
        /// </summary>
        /// <param name="xml">The Xml</param>
        /// <returns>An array of node ids as integer.</returns>
        public static int[] GetXmlIds(string xml)
        {
            var ids = new List<int>();

            if (!string.IsNullOrEmpty(xml))
            {
                using (var xmlReader = XmlReader.Create(new StringReader(xml)))
                {
                    try
                    {
                        xmlReader.Read();

                        // Check name of first element
                        switch (xmlReader.Name)
                        {
                            case "MultiNodePicker":
                            case "XPathCheckBoxList":
                            case "CheckBoxTree":

                                // Position on first <nodeId>
                                xmlReader.ReadStartElement();

                                while (!xmlReader.EOF)
                                {
                                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "nodeId")
                                    {
                                        int id;
                                        if (int.TryParse(xmlReader.ReadElementContentAsString(), out id))
                                        {
                                            ids.Add(id);
                                        }
                                    }
                                    else
                                    {
                                        // Step the reader on
                                        xmlReader.Read();
                                    }
                                }

                                break;
                        }
                    }
                    catch
                    {
                        // Failed to read as Xml
                    }
                }
            }

            return ids.ToArray();
        }
    }
}