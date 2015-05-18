using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;
using System.Linq;

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

            var feature = GeometryFactory.GmlToFeature(e);

            Assert.IsTrue(feature is MultiLineStringFeature);

            MultiLineStringFeature feature2 = new MultiLineStringFeature((MultiLineString)feature.Geometry, feature.Properties);

            Assert.IsTrue(feature2 is MultiLineStringFeature);

        }

        [Test()]
        public void FromGMLPosList() {

            XmlDocument doc = new XmlDocument();
            doc.Load("../posList.gml");

            XmlElement e = doc.DocumentElement;
           
            var geom = GeometryFactory.GmlToGeometry(e);

            Assert.IsTrue(geom is MultiPolygon);

            Assert.AreEqual(36.07, ((GeographicPosition)((MultiPolygon)geom).Polygons[0].LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(50.31, ((MultiPolygon)geom).Coordinates.First().First().First().First());

        }
    }
}

