using NUnit.Framework;
using System;
using System.Xml;
using Terradue.GeoJson.Geometry;
using Terradue.GeoJson.Feature;
using System.Linq;

namespace Terradue.GeoJson.Tests { 

    [TestFixture()]
    public class SplitTests {

        [Test]
        public void SplitPolygon(){

            var poly = GeometryFactory.PolygonFromWKT("POLYGON((160.0 45.0, 170.0 45.0, 175.0 45.0,-179.0 45.0,-178.0 40.0,174.0 40.0, 160.0 45.0))");

            var mpoly = GeometryFactory.SplitWorldExtent(poly);

            var newmpoly = mpoly.ToWkt();

            Assert.AreEqual("MULTIPOLYGON(((160 45,170 45,175 45,180 45,180 40,174 40,160 45)),((-180 45,-179 45,-178 40,-180 40)))", newmpoly);

            poly = GeometryFactory.PolygonFromWKT("POLYGON((160.0 45.0, 170.0 45.0, 175.0 45.0,178.0 40.0,174.0 40.0, 160.0 45.0))");

            mpoly = GeometryFactory.SplitWorldExtent(poly);

            newmpoly = mpoly.ToWkt();

            Assert.AreEqual("POLYGON((160 45,170 45,175 45,178 40,174 40,160 45))", newmpoly);
        }

    }
}

