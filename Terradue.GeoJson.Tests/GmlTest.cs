using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests { 

    [TestFixture()]
    public class GmlTest {

        [Test()]
        public void MultiCurveWithLinearStringTestCase() {

            XmlDocument doc = new XmlDocument();
            doc.Load("../MultiCurveWithLinearString.gml");

            XmlElement e = doc.DocumentElement;

            var geom = GeometryFactory.GmlToGeometry(e);

            Assert.IsTrue(geom is MultiLineString);

        }
    }
}

