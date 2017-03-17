using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests {
    [TestFixture]
    public class DeserializationTest {

        [Test]
        public void MultiPolygonDeserialization() {

            FileStream fs = new FileStream(TestContext.CurrentContext.TestPath("../MultiPolygon.geojson"), FileMode.Open);

            Feature.Feature f;
            var serializer = new JsonSerializer {NullValueHandling = NullValueHandling.Ignore};

            using (var sr = new StreamReader(fs))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                f = serializer.Deserialize<Feature.Feature>(jsonTextReader);
            }
            fs.Close();

            Assert.True(f.Geometry is MultiPolygon);

            string jsonouts;

            using (StringWriter sw = new StringWriter())
            using (JsonTextWriter jw = new JsonTextWriter(sw)) {
                serializer.Serialize(jw, f);
                jsonouts = sw.ToString();
            }

            JToken jsonout;

            using (StringReader str = new StringReader(jsonouts))
            using (JsonTextReader jtr = new JsonTextReader(str)) {
                jsonout = serializer.Deserialize<JToken>(jtr);
            }

            JToken jsonin;
            fs = new FileStream(TestContext.CurrentContext.TestPath("../MultiPolygon.geojson"), FileMode.Open);
            using (var sr2 = new StreamReader(fs))
            using (var jsonTextReader = new JsonTextReader(sr2))
            {
                jsonin = serializer.Deserialize<JToken>(jsonTextReader);
            }
            fs.Close();

            Assert.IsTrue(JToken.DeepEquals(jsonin, jsonout));

        }





        [Test]
        public void WktDeserialization() {

            string fs = "POINT(-115.278 32.297)";

            var geom = WktExtensions.WktToGeometry(fs);

            Assert.True(geom is Point);

        }

        [Test]
        public void PolygonDeserialization() {

            FileStream fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/s1.json"), FileMode.Open);

            Feature.Feature f;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(fs))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                f = serializer.Deserialize<Feature.Feature>(jsonTextReader);
            }


            Assert.True(f.Geometry is Polygon);
            Assert.AreEqual("POLYGON((13.96804 42.817595,12.692281 43.02102,12.369263 41.890703,13.58968 41.69639,13.96804 42.817595))", f.ToWkt());

            ExtendedFeature f2 = new ExtendedFeature(f.Geometry, f.Properties);

            Assert.AreEqual("POLYGON((13.96804 42.817595,12.692281 43.02102,12.369263 41.890703,13.58968 41.69639,13.96804 42.817595))", f2.ToWkt());

        }

        [Test]
        public void PropertiesDeserialization() {

            FileStream fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/ASA_IM__0.json"), FileMode.Open);

            FeatureCollection fc;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(fs))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                fc = serializer.Deserialize<FeatureCollection>(jsonTextReader);
            }

            Assert.False(fc.Features.First().Properties["links"] is String);
        }

        [Test]
        public void PropertiesDeserializationRuCulture()
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-ru");

            FileStream fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/ASA_IM__0.json"), FileMode.Open);

            FeatureCollection fc;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(fs))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                fc = serializer.Deserialize<FeatureCollection>(jsonTextReader);
            }

            Assert.False(fc.Features.First().Properties["links"] is String);
        }

        [Test()]
        public void JsonLongDeserialization()
        {

            FileStream fs = new FileStream(TestContext.CurrentContext.TestPath("../Samples/NigerInnerDeltaRiver.json"), FileMode.Open);

            Terradue.GeoJson.Feature.FeatureCollection fc;
            var serializer = new JsonSerializer();

            using (var sr = new StreamReader(fs))
            using (var jsonTextReader = new JsonTextReader(sr))
            {
                fc = serializer.Deserialize<Terradue.GeoJson.Feature.FeatureCollection>(jsonTextReader);
            }


        }

        [Test()]
        public void WktTest() {

            var geometry = WktExtensions.WktToGeometry("MULTIPOLYGON(((-129.968719 48.14193,-129.968719 48.14193,-131.056732 48.272541,-131.056732 48.272541,-130.657394 49.769352,-130.657394 49.769352,-129.536499 49.638176,-129.536499 49.638176,-129.968719 48.14193)))");

            Assert.AreEqual("MULTIPOLYGON(((-129.968719 48.14193,-131.056732 48.272541,-130.657394 49.769352,-129.536499 49.638176,-129.968719 48.14193)))", geometry.ToWkt());


            geometry = WktExtensions.WktToGeometry("MULTILINESTRING((1 1, 3 5), (-5 3, -8 -2))");

            Assert.AreEqual("MULTILINESTRING((1 1,3 5),(-5 3,-8 -2))", geometry.ToWkt());

        }

    }

    public class ExtendedFeature : Feature.Feature {

        public ExtendedFeature(GeometryObject geom, Dictionary<string, object> prop ) : base(geom, prop){
        }

    }
}

