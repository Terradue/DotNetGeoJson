using System;
using NUnit.Framework;
using Terradue.GeoJson.Geometry;
using System.IO;

namespace Terradue.GeoJson.Tests {

    [TestFixture]
    public class Issues {

        [Test]
        public void Issue9() {

            string wkt = File.ReadAllText("../Samples/Polygon.txt");
            var feature = GeometryFactory.WktToFeature(wkt);

        }
    }
}

