using System;
using System.IO;
using System.Xml;
using NUnit.Framework;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.GeoRss;
using Terradue.GeoJson.Gml321;
using Terradue.ServiceModel.Ogc.Gml321;

namespace Terradue.GeoJson.Tests
{
  [TestFixture]
  public class Gml32Test
  {
    [Test]
    public void FromGMLMultiPoint()
    {
      var fs = new FileStream("Samples/multipoint32.gml".TestDirectory(), FileMode.Open);

      var reader = XmlReader.Create(fs);

      var gml = GmlHelper.Deserialize(reader);

      fs.Close();

      var geom = (MultiPoint) gml.ToGeometry();

      gml = geom.ToGml();

      Assert.That(gml is MultiPointType);

      var sw = new StringWriter();

      var xw = XmlWriter.Create(sw);

      GmlHelper.Serialize(xw, gml);

      var xml1 = sw.ToString();
    }


    [Test]
    public void Gml32MultiCurveWithLinearStringTestCase()
    {
      var fs = new FileStream("Samples/MultiCurveWithLinearString32.gml".TestDirectory(), FileMode.Open);

      var reader = XmlReader.Create(fs);

      var gml = GmlHelper.Deserialize(reader);

      fs.Close();

      var geom = (MultiLineString) gml.ToGeometry();

      gml = geom.ToGmlMultiCurve();

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
    public void Gml32MultiSurfaceTestCase()
    {
      var fs = new FileStream("Samples/Multisurface32.gml".TestDirectory(), FileMode.Open, FileAccess.Read);

      var reader = XmlReader.Create(fs);

      var gml = GmlHelper.Deserialize(reader);

      fs.Close();

      var geom = (MultiPolygon) gml.ToGeometry();

      gml = geom.ToGml();

      Assert.That(gml is MultiSurfaceType);

      var sw = new StringWriter();

      var xw = XmlWriter.Create(sw);

      GmlHelper.Serialize(xw, gml);

      var xml1 = sw.ToString();
    }

    [Test]
    public void Gml32MultiSurfaceToGeorss()
    {
      var fs = new FileStream("Samples/multisurface32-3.xml".TestDirectory(), FileMode.Open, FileAccess.Read);

      var reader = XmlReader.Create(fs);

      var gml = GmlHelper.Deserialize(reader);

      fs.Close();

      Assert.Throws<IndexOutOfRangeException>(() => gml.ToGeometry());
    }

    [Test]
    public void Gml32MultiSurfaceToGeorss4()
    {
      var fs = new FileStream("Samples/multisurface32-4.xml".TestDirectory(), FileMode.Open, FileAccess.Read);

      var reader = XmlReader.Create(fs);

      var gml = GmlHelper.Deserialize(reader);

      fs.Close();

      var geom = gml.ToGeometry();

      Assert.IsTrue(geom is MultiPolygon);

      var georss = (GeoRssWhere) geom.ToGeoRss();

      Assert.AreEqual("multipolygon", georss.Type);

      var georss2 = (GeoRssWhere) GeoRssHelper.Deserialize(georss.CreateReader());

      Assert.AreEqual("multipolygon", georss2.Type);

      var geom2 = georss.ToGeometry();

      Assert.IsTrue(geom2 is MultiPolygon);

      var json = new Feature.Feature(geom, null);
    }

    [Test]
    public void Gml32MultiSurfaceWithDBSTestCase()
    {
      var fs = new FileStream("Samples/multisurface321withDBS.xml".TestDirectory(), FileMode.Open, FileAccess.Read);

      var reader = XmlReader.Create(fs);

      var gml = GmlHelper.Deserialize(reader);

      fs.Close();

      var geom = (MultiPolygon) gml.ToGeometry();

      gml = geom.ToGml();

      Assert.That(gml is MultiSurfaceType);

      var sw = new StringWriter();

      var xw = XmlWriter.Create(sw);

      GmlHelper.Serialize(xw, gml);

      var xml1 = sw.ToString();
    }
  }
}