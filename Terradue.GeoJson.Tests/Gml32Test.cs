using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;
using System.Linq;
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.GeoJson.Gml321;
using System.IO;
using System.Xml.Linq;
using Terradue.GeoJson.GeoRss;

namespace Terradue.GeoJson.Tests { 

    [TestFixture()]
    public class Gml32Test {


        [Test()]
        public void Gml32MultiCurveWithLinearStringTestCase() {

            var fs = new FileStream("../Samples/MultiCurveWithLinearString32.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            MultiLineString geom = (MultiLineString)gml.ToGeometry();

            gml = geom.ToGmlMultiCurve();

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

            gml = geom.ToGmlMultiCurve();

            sw = new StringWriter();

            xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            xw.Close();

            xml1 = sw.ToString();

        }

        [Test()]
        public void Gml32MultiSurfaceTestCase() {

			var fs = new FileStream("../Samples/Multisurface32.gml", FileMode.Open, FileAccess.Read);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            MultiPolygon geom = (MultiPolygon)gml.ToGeometry();

            gml = geom.ToGml();

            Assert.That(gml is MultiSurfaceType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

        }

		[Test()]
		public void Gml32MultiSurfaceWithDBSTestCase()
		{

			var fs = new FileStream("../Samples/multisurface321withDBS.xml", FileMode.Open, FileAccess.Read);

			XmlReader reader = XmlReader.Create(fs);

			AbstractGeometryType gml = GmlHelper.Deserialize(reader);

			fs.Close();

			MultiPolygon geom = (MultiPolygon)gml.ToGeometry();

			gml = geom.ToGml();

			Assert.That(gml is MultiSurfaceType);

			StringWriter sw = new StringWriter();

			XmlWriter xw = XmlWriter.Create(sw);

			GmlHelper.Serialize(xw, gml);

			string xml1 = sw.ToString();

		}

        [Test()]
        public void FromGMLMultiPoint() {

            var fs = new FileStream("../Samples/multipoint32.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            MultiPoint geom = (MultiPoint)gml.ToGeometry();

            gml = geom.ToGml();

            Assert.That(gml is MultiPointType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

        }

        [Test()]
        public void Gml32MultiSurfaceToGeorss()
        {

            var fs = new FileStream("../Samples/multisurface32-3.xml", FileMode.Open, FileAccess.Read);

            XmlReader reader = XmlReader.Create(fs);

            var gml = Terradue.ServiceModel.Ogc.Gml321.GmlHelper.Deserialize(reader);

            fs.Close();

            Assert.Throws<IndexOutOfRangeException>(() => Terradue.GeoJson.Gml321.Gml321Extensions.ToGeometry(gml));


        }

        [Test()]
        public void Gml32MultiSurfaceToGeorss4()
        {

            var fs = new FileStream("../Samples/multisurface32-4.xml", FileMode.Open, FileAccess.Read);

            XmlReader reader = XmlReader.Create(fs);

            var gml = Terradue.ServiceModel.Ogc.Gml321.GmlHelper.Deserialize(reader);

            fs.Close();

            var geom = Terradue.GeoJson.Gml321.Gml321Extensions.ToGeometry(gml);

            Assert.IsTrue(geom is MultiPolygon);

            GeoRssWhere georss = (GeoRssWhere)geom.ToGeoRss();

            Assert.AreEqual("multipolygon", georss.Type);

            GeoRssWhere georss2 = (GeoRssWhere)GeoRssHelper.Deserialize(georss.CreateReader());

            Assert.AreEqual("multipolygon", georss2.Type);

            var geom2 = georss.ToGeometry();

            Assert.IsTrue(geom2 is MultiPolygon);

            var json = new Terradue.GeoJson.Feature.Feature(geom, null);

        }

    }
}

