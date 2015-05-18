using System.Xml;
using NUnit.Framework;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests
{
  [TestFixture]
  public class GeoRSSTest
  {
    [Test]
    public void PolygonTestCase()
    {
      var doc = new XmlDocument();
      doc.Load("../polygon.georss");

      var e = doc.DocumentElement;

      var geom = GeometryFactory.GeoRSSToGeometry(e);

      Assert.IsTrue(geom is Polygon);
    }
  }
}