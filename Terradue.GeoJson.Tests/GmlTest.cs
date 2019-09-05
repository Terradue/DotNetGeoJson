using System.IO;
using System.Linq;
using System.Xml;
using NUnit.Framework;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Gml311;
using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.GeoJson.Tests
{

	[TestFixture]
	public class GmlTest
	{

		[Test]
		public void GmlMultiPolygonTestCase()
		{

			var fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/MultiPolygon.xml"), FileMode.Open);

			var reader = XmlReader.Create(fs);

			var gml = GmlHelper.Deserialize(reader);

			fs.Close();

			var geom = (MultiPolygon)gml.ToGeometry();

			gml = geom.ToGmlMultiSurface();

			var sw = new StringWriter();

			var xw = XmlWriter.Create(sw);

			GmlHelper.Serialize(xw, gml);

			xw.Close();

			gml = geom.ToGmlMultiPolygon();

			sw = new StringWriter();

			xw = XmlWriter.Create(sw);

			GmlHelper.Serialize(xw, gml);

			//Assert.IsTrue(XNode.DeepEquals(XDocument.Load("../Samples/MultiPolygon.xml").Root, XDocument.Parse(xml1).Root));

		}

		[Test]
		public void GmlMultiCurveWithLinearStringTestCase()
		{

			var fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/MultiCurveWithLinearString.gml"), FileMode.Open);

			var reader = XmlReader.Create(fs);

			var gml = GmlHelper.Deserialize(reader);

			fs.Close();

			var geom = (MultiLineString)gml.ToGeometry();

			gml = geom.ToGmlMultiLineString();

			var sw = new StringWriter();

			var xw = XmlWriter.Create(sw);

			GmlHelper.Serialize(xw, gml);

			var xml1 = sw.ToString();

			gml = geom.ToGmlMultiCurve();

			sw = new StringWriter();

			xw = XmlWriter.Create(sw);

			GmlHelper.Serialize(xw, gml);

			xw.Close();

			xml1 = sw.ToString();

		}

		[Test]
		public void GmlMultiSurfaceTestCase()
		{

			var fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/MultiSurface311.gml"), FileMode.Open);

			var reader = XmlReader.Create(fs);

			var gml = GmlHelper.Deserialize(reader);

			fs.Close();

			var geom = (MultiPolygon)gml.ToGeometry();

			gml = geom.ToGml();

			Assert.That(gml is MultiPolygonType);

			var sw = new StringWriter();

			var xw = XmlWriter.Create(sw);

			GmlHelper.Serialize(xw, gml);

			var xml1 = sw.ToString();

		}

		[Test]
		public void CreatePolygonFromNonClosedLineString()
		{

			var ls = new LineString(new[] { new GeographicPosition(-10, 10), new GeographicPosition(-10, 5) }.Cast<IPosition>().ToList());

			var poly = new Polygon(new[] { ls }.ToList());

			poly.ToGml();

		}

        [Test]
        public void PoslistWithNewlines()
        {
            var testFile = TestContext.CurrentContext.TestPath("../Samples/PoslistWithNewlines.gml");
            using (var fs = new FileStream(testFile, FileMode.Open))
            {
                using (var reader = XmlReader.Create(fs))
                {
                    var gmlObject = GmlHelper.Deserialize(reader);
                    var geom = (Polygon)gmlObject.ToGeometry();
                    Assert.That(geom.Coordinates.Single().Count, Is.EqualTo(10));
                }
            }
        }
	}
}

