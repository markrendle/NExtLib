using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Xml.Linq
{
    public static class XElementExtensions
    {
        public static XElement Element(this XElement element, string prefix, string name)
        {
            var ns = string.IsNullOrEmpty(prefix) ? element.GetDefaultNamespace() : element.GetNamespaceOfPrefix(prefix);
            return element.Element(ns + name);
        }

        public static IEnumerable<XElement> Elements(this XElement element, string prefix, string name)
        {
            var ns = string.IsNullOrEmpty(prefix) ? element.GetDefaultNamespace() : element.GetNamespaceOfPrefix(prefix);
            return element.Elements(ns + name);
        }

        public static XAttribute Attribute(this XElement element, string prefix, string name)
        {
            var ns = string.IsNullOrEmpty(prefix) ? element.GetDefaultNamespace() : element.GetNamespaceOfPrefix(prefix);
            return element.Attribute(ns + name);
        }
    }
}
