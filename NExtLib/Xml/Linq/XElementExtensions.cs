using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Xml.Linq
{
    public static class XElementExtensions
    {
        public static XElement XElement(this XElement element, string name)
        {
            var xname = element.GetDefaultNamespace() + name;
            return element.Element(xname);
        }

        public static IEnumerable<XElement> XElements(this XElement element, string name)
        {
            var xname = element.GetDefaultNamespace() + name;
            return element.Elements(xname);
        }
    }
}
