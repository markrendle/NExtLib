using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NExtLib.UnitTest
{
    public static class ShouldExtensions
    {
        public static void ShouldEqual<T>(this T actual, T expected)
        {
            Assert.AreEqual(actual, expected);
        }
    }
}
