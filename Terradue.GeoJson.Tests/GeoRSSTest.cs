using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using Terradue.ServiceModel.Ogc.Gml311;
using Terradue.GeoJson.Gml311;
using Terradue.GeoJson.GeoRss;
using System.Linq;
using Terradue.GeoJson.GeoRss10;

namespace Terradue.GeoJson.Tests {

    [TestFixture()]
    public class GeoRSSTest {

        [Test()]
        public void GeoRssPointTestCase() {

            string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?><georss:point xmlns:georss=\"http://www.georss.org/georss\">45.256 -71.92</georss:point>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssPoint point = (Terradue.GeoJson.GeoRss.GeoRssPoint)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = point.ToGeometry();

            Assert.That(geom is Point);

            Assert.That(((Point)geom).Position is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Point)geom).Position).Latitude);

            Assert.AreEqual(-71.92, ((GeographicPosition)((Point)geom).Position).Longitude);

            point = (Terradue.GeoJson.GeoRss.GeoRssPoint)geom.ToGeoRss();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), point);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssLineTestCase() {

            string xml = "<georss:line xmlns:georss=\"http://www.georss.org/georss\">45.256 -110.45 46.46 -109.48 43.84 -109.86</georss:line>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssLine line = (Terradue.GeoJson.GeoRss.GeoRssLine)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = line.ToGeometry();

            Assert.That(geom is LineString);

            Assert.That(((LineString)geom).Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((LineString)geom).Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((LineString)geom).Positions[0]).Longitude);

            Assert.False(((LineString)geom).IsClosed());

            line = (Terradue.GeoJson.GeoRss.GeoRssLine)geom.ToGeoRss();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), line);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssPloygonTestCase() {

            string xml = "<georss:polygon xmlns:georss=\"http://www.georss.org/georss\">45.256 -110.45 46.46 -109.48 43.84 -109.86 45.256 -110.45</georss:polygon>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssPolygon line = (Terradue.GeoJson.GeoRss.GeoRssPolygon)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = line.ToGeometry();

            Assert.That(geom is Polygon);

            Assert.That(((Polygon)geom).LineStrings[0].Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Longitude);

            Assert.True(((Polygon)geom).LineStrings[0].IsClosed());

            line = (Terradue.GeoJson.GeoRss.GeoRssPolygon)geom.ToGeoRss();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), line);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssBoxTestCase() {

            string xml = "<georss:box xmlns:georss=\"http://www.georss.org/georss\">42.943 -71.032 43.039 -69.856</georss:box>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssBox box = (Terradue.GeoJson.GeoRss.GeoRssBox)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = box.ToGeometry();

            Assert.That(geom is Polygon);

            Assert.That(((Polygon)geom).LineStrings[0].Positions[0] is GeographicPosition);

            Assert.AreEqual(42.943, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(-71.032, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Longitude);

            Assert.AreEqual(42.943, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[1]).Latitude);

            Assert.AreEqual(-69.856, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[1]).Longitude);

            Assert.True(((Polygon)geom).LineStrings[0].IsClosed());

            var poly = (Terradue.GeoJson.GeoRss.GeoRssPolygon)geom.ToGeoRss();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), poly);

            var xml1 = sw.ToString();

            sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), box);

            sw.Close();

            xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssWherePointTestCase() {

            string xml = "<georss:where xmlns:gml=\"http://www.opengis.net/gml\" xmlns:georss=\"http://www.georss.org/georss\">\n         <gml:Point>\n            <gml:pos>45.256 -71.92</gml:pos>\n         </gml:Point>\n      </georss:where>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssWhere where = (Terradue.GeoJson.GeoRss.GeoRssWhere)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = where.ToGeometry();

            Assert.That(geom is Point);

            Assert.That(((Point)geom).Position is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Point)geom).Position).Latitude);

            Assert.AreEqual(-71.92, ((GeographicPosition)((Point)geom).Position).Longitude);

            where = (Terradue.GeoJson.GeoRss.GeoRssWhere)geom.ToGeoRssWhere();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), where);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssWhereLineTestCase() {

            string xml = "<georss:where xmlns:gml=\"http://www.opengis.net/gml\" xmlns:georss=\"http://www.georss.org/georss\">\n         <gml:LineString>\n         <gml:posList count=\"3\">45.256 -110.45 46.46 -109.48 43.84 -109.86</gml:posList>\n      </gml:LineString></georss:where>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssWhere where = (Terradue.GeoJson.GeoRss.GeoRssWhere)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = where.ToGeometry();

            Assert.That(geom is LineString);

            Assert.That(((LineString)geom).Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((LineString)geom).Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((LineString)geom).Positions[0]).Longitude);

            where = (Terradue.GeoJson.GeoRss.GeoRssWhere)geom.ToGeoRssWhere();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), where);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssWherePolygonTestCase() {

            string xml = "<georss:where xmlns:gml=\"http://www.opengis.net/gml\" xmlns:georss=\"http://www.georss.org/georss\">\n         <gml:Polygon>\n         <gml:exterior>\n            <gml:LinearRing>\n               <gml:posList count=\"4\">45.256 -110.45 46.46 -109.48 43.84 -109.86 45.256 -110.45</gml:posList>\n            </gml:LinearRing>\n         </gml:exterior>\n      </gml:Polygon></georss:where>";

            var reader = XmlReader.Create(new StringReader(xml));

            Terradue.GeoJson.GeoRss.GeoRssWhere where = (Terradue.GeoJson.GeoRss.GeoRssWhere)Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(reader);

            var geom = where.ToGeometry();

            Assert.That(geom is Polygon);

            Assert.That(((Polygon)geom).LineStrings[0].Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Longitude);

            where = (Terradue.GeoJson.GeoRss.GeoRssWhere)geom.ToGeoRssWhere();
            var sw = new StringWriter();

            Terradue.GeoJson.GeoRss.GeoRssHelper.Serialize(XmlWriter.Create(sw), where);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test()]
        public void GeoRssFromAtomFeed() {

            Terradue.ServiceModel.Syndication.Atom10FeedFormatter atomf = new Terradue.ServiceModel.Syndication.Atom10FeedFormatter();

            atomf.ReadFrom(XmlReader.Create(new FileStream("../Samples/landsat8.xml", FileMode.Open, FileAccess.Read)));

            GeometryObject geom;

            foreach (var ext in atomf.Feed.Items.First().ElementExtensions) {

                XmlReader xr = ext.GetReader();

                switch (xr.NamespaceURI) {
                    // 1) search for georss
                    case "http://www.georss.org/georss":
                        geom = Terradue.GeoJson.GeoRss.GeoRssHelper.Deserialize(xr).ToGeometry();
                        break;
                        // 2) search for georss10
                    case "http://www.georss.org/georss/10":
                        geom = GeoRss10Extensions.ToGeometry(GeoRss10Helper.Deserialize(xr));
                        break;
                        // 3) search for dct:spatial
                    case "http://purl.org/dc/terms/":
                        if (xr.LocalName == "spatial")
                            geom = WktExtensions.WktToGeometry(xr.ReadContentAsString());
                        break;
                    default:
                        continue;
                }

            }
        }

        [Test()]
        public void GeoRssFromFile1() {

            var xr = XmlReader.Create(new FileStream("../Samples/georsswhere.xml", FileMode.Open, FileAccess.Read));

            var geom = GeoRss10Helper.Deserialize(xr).ToGeometry();

        }

    }
}

