using NUnit.Framework;
using System;
using System.IO;
using ServiceStack.Text;
using Terradue.GeoJson.Feature;

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
    }
}

