using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Xml.Linq;
using NExtLib.UnitTest;

namespace NExtLib.Tests.Xml.Linq
{
    [TestFixture]
    public class XElementExtensionsTests
    {
        [Test]
        public void TestXElementWithDefaultNamespace()
        {
            var element = XElement.Parse(Properties.Resources.XmlWithDefaultNamespace);
            var list = element.XElements("child").ToList();
            list.Count.ShouldEqual(2);
            list[0].XElement("sub").Value.ShouldEqual("Foo");
            list[1].XElement("sub").Value.ShouldEqual("Bar");
        }

        [Test]
        public void TestXElementWithNoNamespace()
        {
            var element = XElement.Parse(Properties.Resources.XmlWithNoNamespace);
            var list = element.XElements("child").ToList();
            list.Count.ShouldEqual(2);
            list[0].XElement("sub").Value.ShouldEqual("Foo");
            list[1].XElement("sub").Value.ShouldEqual("Bar");
        }
    }
}
