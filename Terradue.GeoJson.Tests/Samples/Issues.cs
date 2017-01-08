using System.IO;
using NUnit.Framework;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests {

    [TestFixture]
    public class Issues {

        [Test]
        public void Issue9() {

            var wkt = File.ReadAllText(TestContext.CurrentContext.TestPath("../Samples/Polygon.txt"));
            var geom = WktExtensions.WktToGeometry(wkt);

            Assert.That(geom is Polygon);

        }
    }
}

