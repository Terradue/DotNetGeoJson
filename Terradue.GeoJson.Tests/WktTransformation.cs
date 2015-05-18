using System.Collections.Generic;
using NUnit.Framework;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests
{
  [TestFixture]
  public class WktTransformation
  {
    private readonly GeographicPosition Position1 = new GeographicPosition(10, 124);
    private readonly GeographicPosition Position2 = new GeographicPosition(11, 124);
    private readonly GeographicPosition Position3 = new GeographicPosition(10, 125);
    private readonly GeographicPosition Position4 = new GeographicPosition(10, 124);

    [Test]
    public void PointFeatureToWkt()
    {
      var pointf = new PointFeature(new Point(Position1));
      var wkt = pointf.ToWkt();
      Assert.AreEqual("POINT(124 10)", wkt);
    }

    [Test]
    public void LineStringFeatureToWkt()
    {
      var linestringf =
        new LineStringFeature(new LineString(
          new List<IPosition> {Position1, Position2, Position3}));
      var wkt = linestringf.ToWkt();
      Assert.AreEqual("LINESTRING(124 10,124 11,125 10)", wkt);
    }

    [Test]
    public void PolygonFeatureToWkt()
    {
      var list = new List<LineString>();
      list.Add(new LineString(
        new List<IPosition> {Position1, Position2, Position3, Position4}));

      var polygonf =
        new PolygonFeature(new Polygon(list));
      var wkt = polygonf.ToWkt();
      Assert.AreEqual("POLYGON((124 10,124 11,125 10,124 10))", wkt);
    }
  }
}