using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;

namespace Terradue.GeoJson.Tests { 

    [TestFixture()]
    public class GeoRSSTest {

        [Test()]
        public void PolygonTestCase() {

            XmlDocument doc = new XmlDocument();
            doc.Load("../polygon.georss");

            XmlElement e = doc.DocumentElement;

            var geom = GeometryFactory.GeoRSSToGeometry(e);

            Assert.IsTrue(geom is Polygon);

        }
    }
}

