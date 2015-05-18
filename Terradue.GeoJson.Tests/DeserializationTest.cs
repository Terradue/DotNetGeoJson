using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using ServiceStack.Text;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests
{
  [TestFixture]
  public class DeserializationTest
  {
    [Test]
    public void MultiPolygonDeserialization()
    {
      var fs = new FileStream("../MultiPolygon.geojson", FileMode.Open);

      var f = JsonSerializer.DeserializeFromStream<Feature.Feature>(fs);
      fs.Close();

      Assert.True(f is MultiPolygonFeature);
    }

    [Test]
    public void WktDeserialization()
    {
      const string fs = "POINT(-115.278 32.297)";

      var point = GeometryFactory.WktToFeature(fs);

      Assert.True(point is PointFeature);
    }

    [Test]
    public void PolygonDeserialization()
    {
      var fs = new FileStream("../Samples/s1.json", FileMode.Open);

      var f = JsonSerializer.DeserializeFromStream<Feature.Feature>(fs);
      fs.Close();

      Assert.True(f is PolygonFeature);
      Assert.AreEqual(
        "POLYGON((13.96804 42.817595,12.692281 43.02102,12.369263 41.890703,13.58968 41.69639,13.96804 42.817595))",
        f.ToWkt());

      var f2 = new ExtendedFeature(f.Geometry, f.Properties);

      Assert.AreEqual(
        "POLYGON((13.96804 42.817595,12.692281 43.02102,12.369263 41.890703,13.58968 41.69639,13.96804 42.817595))",
        f2.ToWkt());
    }
  }

  public class ExtendedFeature : Feature.Feature
  {
    public ExtendedFeature(IGeometryObject geom, Dictionary<string, object> prop) : base(geom, prop)
    {
    }
  }
}