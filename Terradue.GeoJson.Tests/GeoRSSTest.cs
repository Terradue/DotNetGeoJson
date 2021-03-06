using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using NUnit.Framework;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Gml321;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss;
using Terradue.ServiceModel.Ogc.GeoRss.GeoRss10;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.ServiceModel.Syndication;

namespace Terradue.GeoJson.Tests {

    [TestFixture]
    public class GeoRSSTest {

        [Test]
        public void GeoRssPointTestCase() {

            const string xml = "<?xml version=\"1.0\" encoding=\"utf-16\"?><georss:point xmlns:georss=\"http://www.georss.org/georss\">45.256 -71.92</georss:point>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssPoint point = (GeoRssPoint)GeoRssHelper.Deserialize(reader);

            var geom = point.ToGeometry();

            Assert.That(geom is Point);

            Assert.That(((Point)geom).Position is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Point)geom).Position).Latitude);

            Assert.AreEqual(-71.92, ((GeographicPosition)((Point)geom).Position).Longitude);

            point = (GeoRssPoint)geom.ToGeoRss();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), point);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test]
        public void GeoRssLineTestCase() {

            string xml = "<georss:line xmlns:georss=\"http://www.georss.org/georss\">45.256 -110.45 46.46 -109.48 43.84 -109.86</georss:line>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssLine line = (GeoRssLine)GeoRssHelper.Deserialize(reader);

            var geom = line.ToGeometry();

            Assert.That(geom is LineString);

            Assert.That(((LineString)geom).Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((LineString)geom).Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((LineString)geom).Positions[0]).Longitude);

            Assert.False(((LineString)geom).IsClosed());

            line = (GeoRssLine)geom.ToGeoRss();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), line);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test]
        public void GeoRssPloygonTestCase() {

            string xml = "<georss:polygon xmlns:georss=\"http://www.georss.org/georss\">45.256 -110.45 46.46 -109.48 43.84 -109.86 45.256 -110.45</georss:polygon>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssPolygon line = (GeoRssPolygon)GeoRssHelper.Deserialize(reader);

            var geom = line.ToGeometry();

            Assert.That(geom is Polygon);

            Assert.That(((Polygon)geom).LineStrings[0].Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Longitude);

            Assert.True(((Polygon)geom).LineStrings[0].IsClosed());

            line = (GeoRssPolygon)geom.ToGeoRss();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), line);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test]
        public void GeoRssBoxTestCase() {

            string xml = "<georss:box xmlns:georss=\"http://www.georss.org/georss\">42.943 -71.032 43.039 -69.856</georss:box>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssBox box = (GeoRssBox)GeoRssHelper.Deserialize(reader);

            var geom = box.ToGeometry();

            Assert.That(geom is Polygon);

            Assert.That(((Polygon)geom).LineStrings[0].Positions[0] is GeographicPosition);

            Assert.AreEqual(42.943, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(-71.032, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Longitude);

            Assert.AreEqual(42.943, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[1]).Latitude);

            Assert.AreEqual(-69.856, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[1]).Longitude);

            Assert.True(((Polygon)geom).LineStrings[0].IsClosed());

            var poly = (GeoRssPolygon)geom.ToGeoRss();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), poly);

            var xml1 = sw.ToString();

            sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), box);

            sw.Close();

            xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test]
        public void GeoRssWherePointTestCase() {

            string xml = "<georss:where xmlns:gml=\"http://www.opengis.net/gml\" xmlns:georss=\"http://www.georss.org/georss\">\n         <gml:Point>\n            <gml:pos>45.256 -71.92</gml:pos>\n         </gml:Point>\n      </georss:where>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssWhere where = (GeoRssWhere)GeoRssHelper.Deserialize(reader);

            var geom = where.ToGeometry();

            Assert.That(geom is Point);

            Assert.That(((Point)geom).Position is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Point)geom).Position).Latitude);

            Assert.AreEqual(-71.92, ((GeographicPosition)((Point)geom).Position).Longitude);

            where = geom.ToGeoRssWhere();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), where);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test]
        public void GeoRssWhereLineTestCase() {

            string xml = "<georss:where xmlns:gml=\"http://www.opengis.net/gml\" xmlns:georss=\"http://www.georss.org/georss\">\n         <gml:LineString>\n         <gml:posList count=\"3\">45.256 -110.45 46.46 -109.48 43.84 -109.86</gml:posList>\n      </gml:LineString></georss:where>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssWhere where = (GeoRssWhere)GeoRssHelper.Deserialize(reader);

            var geom = where.ToGeometry();

            Assert.That(geom is LineString);

            Assert.That(((LineString)geom).Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((LineString)geom).Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((LineString)geom).Positions[0]).Longitude);

            where = geom.ToGeoRssWhere();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), where);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

			where.CreateReader();

        }

        [Test]
        public void GeoRssWherePolygonTestCase() {

            string xml = "<georss:where xmlns:gml=\"http://www.opengis.net/gml\" xmlns:georss=\"http://www.georss.org/georss\">\n         <gml:Polygon>\n         <gml:exterior>\n            <gml:LinearRing>\n               <gml:posList count=\"4\">45.256 -110.45 46.46 -109.48 43.84 -109.86 45.256 -110.45</gml:posList>\n            </gml:LinearRing>\n         </gml:exterior>\n      </gml:Polygon></georss:where>";

            var reader = XmlReader.Create(new StringReader(xml));

            GeoRssWhere where = (GeoRssWhere)GeoRssHelper.Deserialize(reader);

            var geom = where.ToGeometry();

            Assert.That(geom is Polygon);

            Assert.That(((Polygon)geom).LineStrings[0].Positions[0] is GeographicPosition);

            Assert.AreEqual(45.256, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Latitude);

            Assert.AreEqual(-110.45, ((GeographicPosition)((Polygon)geom).LineStrings[0].Positions[0]).Longitude);

            where = geom.ToGeoRssWhere();
            var sw = new StringWriter();

            GeoRssHelper.Serialize(XmlWriter.Create(sw), where);

            sw.Close();

            var xml1 = sw.ToString();

            Assert.IsTrue(XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(xml1).Root));

        }

        [Test]
        public void GeoRssFromAtomFeed() {

            Terradue.ServiceModel.Syndication.Atom10FeedFormatter atomf = new Terradue.ServiceModel.Syndication.Atom10FeedFormatter();

            atomf.ReadFrom(XmlReader.Create(new FileStream(TestContext.CurrentContext.TestPath("../Samples/landsat8.xml"), FileMode.Open, FileAccess.Read)));

            GeometryObject geom;

            foreach (var ext in atomf.Feed.Items.First().ElementExtensions) {

                XmlReader xr = ext.GetReader();

                switch (xr.NamespaceURI) {
                    // 1) search for georss
                    case "http://www.georss.org/georss":
                        geom = GeoRssHelper.Deserialize(xr).ToGeometry();
                        break;
                        // 2) search for georss10
                    case "http://www.georss.org/georss/10":
                        geom = GeoRss10Helper.Deserialize(xr).ToGeometry();
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

        [Test]
        public void GeoRssFromFile1() {

            var xr = XmlReader.Create(new FileStream(TestContext.CurrentContext.TestPath("../Samples/georsswhere.xml"), FileMode.Open, FileAccess.Read));

            var geom = GeoRss10Helper.Deserialize(xr).ToGeometry();

        }

        [Test]
        public void GeoRssFromFile2()
        {

            var xr = XmlReader.Create(new FileStream(TestContext.CurrentContext.TestPath("../Samples/noa-ers-georss.xml"), FileMode.Open, FileAccess.Read));

            MultiPolygon geom = GeoRssHelper.Deserialize(xr).ToGeometry() as MultiPolygon;

            Assert.IsNotNull(geom);

            xr = XmlReader.Create(new FileStream(TestContext.CurrentContext.TestPath("../Samples/noa-ers-georss.xml"), FileMode.Open, FileAccess.Read));

            MultiPolygon geom2 = GeoRssHelper.Deserialize(xr).ToGeometry() as MultiPolygon;

            geom.Polygons.Add(geom2.Polygons[0]);

            geom.ToGeoRss();

        }

		[Test]
		public void Gml32MultiSurfaceToGeorss()
		{

			var fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/multisurface32-2.xml"), FileMode.Open, FileAccess.Read);

			XmlReader reader = XmlReader.Create(fs);

			var gml = GmlHelper.Deserialize(reader);

			fs.Close();

			MultiPolygon geom = (MultiPolygon)Terradue.GeoJson.Gml321.Gml321Extensions.ToGeometry(gml);

			XmlDocument doc = new XmlDocument();
			doc.Load(geom.ToGeoRss().CreateReader());
			doc.Save(TestContext.CurrentContext.TestPath("../out/georssfromgml32.xml"));

		}

        [Test]
        public void ComplexWKTToGml(){
            var fs = new FileInfo(TestContext.CurrentContext.TestPath("../Samples/longwkt.txt"));

			StreamReader sr = new StreamReader(fs.OpenRead());

            var wkt = sr.ReadToEnd();

            var geom = WktExtensions.WktToGeometry(wkt);

            var georss = geom.ToGeoRss();

            Assert.That(georss is GeoRssWhere);

            Assert.That(((GeoRssWhere)georss).Item[0] is Terradue.ServiceModel.Ogc.Gml311.PolygonType);

            Terradue.ServiceModel.Ogc.Gml311.PolygonType polygon = ((GeoRssWhere)georss).Item[0] as Terradue.ServiceModel.Ogc.Gml311.PolygonType;

            Assert.AreEqual(Terradue.ServiceModel.Ogc.Gml311.ItemChoiceType5.exterior, polygon.ItemElementName);

            Assert.IsNotNull(polygon.Item);

            Assert.True(polygon.Items1ElementName.All(i => i == Terradue.ServiceModel.Ogc.Gml311.Items1ChoiceType3.interior));

            Assert.AreEqual(16, polygon.Items1.Count());

        }
    }
}

