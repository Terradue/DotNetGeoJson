using NUnit.Framework;
using System;
using System.IO;
using ServiceStack.Text;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace Terradue.GeoJson.Tests {
    [TestFixture()]
    public class DeserializationTest {

        [Test()]
        public void MultiPolygonDeserialization() {

            FileStream fs = new FileStream("../MultiPolygon.geojson", FileMode.Open);

            Terradue.GeoJson.Feature.Feature f = JsonSerializer.DeserializeFromStream<Terradue.GeoJson.Feature.Feature>(fs);
            fs.Close();

            Assert.True(f is MultiPolygonFeature);

        }

        [Test()]
        public void WktDeserialization() {

            string fs = "POINT(-115.278 32.297)";

            Terradue.GeoJson.Feature.Feature point = Geometry.GeometryFactory.WktToFeature(fs);

            Assert.True(point is PointFeature);

        }

        [Test()]
        public void PolygonDeserialization() {

            FileStream fs = new FileStream("../Samples/s1.json", FileMode.Open);

            Terradue.GeoJson.Feature.Feature f = JsonSerializer.DeserializeFromStream<Terradue.GeoJson.Feature.Feature>(fs);
            fs.Close();

            Assert.True(f is PolygonFeature);
            Assert.AreEqual("POLYGON((13.96804 42.817595,12.692281 43.02102,12.369263 41.890703,13.58968 41.69639,13.96804 42.817595))", f.ToWkt());

            ExtendedFeature f2 = new ExtendedFeature(f.Geometry, f.Properties);

            Assert.AreEqual("POLYGON((13.96804 42.817595,12.692281 43.02102,12.369263 41.890703,13.58968 41.69639,13.96804 42.817595))", f2.ToWkt());

        }

        [Test()]
        public void PropertiesDeserialization() {

            FileStream fs = new FileStream("../Samples/ASA_IM__0.json", FileMode.Open);

            Terradue.GeoJson.Feature.FeatureCollection fc = JsonSerializer.DeserializeFromStream<Terradue.GeoJson.Feature.FeatureCollection>(fs);
            fs.Close();

            Assert.False(fc.Features.First().Properties["links"] is String);
        }
    }

    public class ExtendedFeature : Terradue.GeoJson.Feature.Feature {

        public ExtendedFeature(Terradue.GeoJson.Geometry.IGeometryObject geom, Dictionary<string, object> prop ) : base(geom, prop){
        }

    }
}

