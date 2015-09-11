using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;
using System.IO;
using System.Xml.Linq;

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

        [Test]
        public void Test1(){

            var doc = new XmlDocument();
            var el = XElement.Parse("<georss:box xmlns:georss=\"http://www.georss.org/georss/10\">112.76548 53.4104 116.46048 55.58847</georss:box>");
            doc.Load(el.CreateReader());
            var geometry = GeometryFactory.GeoRSSToGeometry(doc.DocumentElement);
            Assert.That(geometry is Polygon);

            el = XElement.Parse("<georss:polygon xmlns:georss=\"http://www.georss.org/georss/10\">53.89156 112.76548 55.58847 113.56369 55.0966 116.46048 53.4104 115.5499 53.89156 112.76548</georss:polygon>");
            doc.Load(el.CreateReader());
            geometry = GeometryFactory.GeoRSSToGeometry(doc.DocumentElement);
            Assert.That(geometry is Polygon);

            el = XElement.Parse("<georss:polygon xmlns:georss=\"http://www.georss.org/georss/10\">53.89156 112.76548 55.58847 113.56369 55.0966 116.46048 53.4104 115.5499 53.89156 112.76548</georss:polygon>");
            doc.Load(el.CreateReader());
            var feature = GeometryFactory.GeoRSSToFeature(doc.DocumentElement);
            Assert.That(feature.Geometry is Polygon);

            el = XElement.Parse("<MultiSurface xmlns=\"http://www.opengis.net/gml/3.2\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n\t\t\t\t<surfaceMembers>\n\t\t\t\t\t<Polygon>\n\t\t\t\t\t\t<exterior>\n\t\t\t\t\t\t\t<LinearRing>\n\t\t\t\t\t\t\t\t<posList count=\"5\" srsDimension=\"2\">47.6532 -8.6293 46.7177 -8.8848 46.615 -7.8641 47.5494 -7.5905 47.6532 -8.6293</posList>\n\t\t\t\t\t\t\t</LinearRing>\n\t\t\t\t\t\t</exterior>\n\t\t\t\t\t</Polygon>\n\t\t\t\t</surfaceMembers>\n\t\t\t</MultiSurface>");
            doc.Load(el.CreateReader());
            feature = Terradue.GeoJson.Geometry.GeometryFactory.GmlToFeature(doc.DocumentElement);
            Assert.That(feature.Geometry is Polygon);
        }
    }
}

