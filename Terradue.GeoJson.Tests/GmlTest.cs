using System.Linq;
using System.Xml;
using NUnit.Framework;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests
{
  [TestFixture]
  public class GmlTest
  {
    [Test]
    public void MultiCurveWithLinearStringTestCase()
    {
      var doc = new XmlDocument();
      doc.Load("../MultiCurveWithLinearString.gml");

      var e = doc.DocumentElement;

      var geom = GeometryFactory.GmlToGeometry(e);

      Assert.IsTrue(geom is MultiLineString);

      var feature = GeometryFactory.GmlToFeature(e);

      Assert.IsTrue(feature is MultiLineStringFeature);

      var feature2 = new MultiLineStringFeature((MultiLineString) feature.Geometry, feature.Properties);

      Assert.IsTrue(feature2 is MultiLineStringFeature);
    }

    [Test]
    public void FromGMLPosList()
    {
      var doc = new XmlDocument();
      doc.Load("../posList.gml");

      var e = doc.DocumentElement;

      var geom = GeometryFactory.GmlToGeometry(e);

      Assert.IsTrue(geom is MultiPolygon);

      Assert.AreEqual(36.07,
        ((GeographicPosition) ((MultiPolygon) geom).Polygons[0].LineStrings[0].Positions[0]).Latitude);

      Assert.AreEqual(50.31, ((MultiPolygon) geom).Coordinates.First().First().First().First());
    }
  }
}