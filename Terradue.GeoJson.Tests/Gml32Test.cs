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

            var fs = new FileStream("../Samples/MultiSurface32.gml", FileMode.Open);

            XmlReader reader = XmlReader.Create(fs);

            AbstractGeometryType gml = GmlHelper.Deserialize(reader);

            fs.Close();

            MultiPolygon geom = (MultiPolygon)gml.ToGeometry();

            gml = geom.ToGml();

            Assert.That(gml is MultiPolygonType);

            StringWriter sw = new StringWriter();

            XmlWriter xw = XmlWriter.Create(sw);

            GmlHelper.Serialize(xw, gml);

            string xml1 = sw.ToString();

        }

    }
}

