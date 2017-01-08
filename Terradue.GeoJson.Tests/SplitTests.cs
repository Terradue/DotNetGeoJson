using NUnit.Framework;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Tests { 

    [TestFixture]
    public class SplitTests {

        [Test]
        public void SplitPolygon(){

            var poly = WktExtensions.PolygonFromWKT("POLYGON((160.0 45.0, 170.0 45.0, 175.0 45.0,-179.0 45.0,-178.0 40.0,174.0 40.0, 160.0 45.0))");

            var mpoly = GeometryFactory.SplitWorldExtent(poly);

            var newmpoly = mpoly.ToWkt();

            Assert.AreEqual("MULTIPOLYGON(((160 45,170 45,175 45,180 45,180 40,174 40,160 45)),((-180 45,-179 45,-178 40,-180 40,-180 45)))", newmpoly);

            poly = WktExtensions.PolygonFromWKT("POLYGON((160.0 45.0, 170.0 45.0, 175.0 45.0,178.0 40.0,174.0 40.0, 160.0 45.0))");

            mpoly = GeometryFactory.SplitWorldExtent(poly);

            newmpoly = mpoly.ToWkt();

            Assert.AreEqual("POLYGON((160 45,170 45,175 45,178 40,174 40,160 45))", newmpoly);

            var mpoly2 = WktExtensions.MultiPolygonFromWKT("MULTIPOLYGON(((138.141861 83.754265,149.33284 87.420456,-166.712769 84.741585,168.046951 82.234276,138.141861 83.754265)))");

            mpoly = GeometryFactory.SplitWorldExtent(mpoly2);

            newmpoly = mpoly.ToWkt();

            Assert.AreEqual("MULTIPOLYGON(((138.141861 83.754265,149.33284 87.420456,180 85.5513966476281,180 83.4216632768107,168.046951 82.234276,138.141861 83.754265)),((-180 85.5513966476281,-166.712769 84.741585,-180 83.4216632768107,-180 85.5513966476281)))", newmpoly);

            mpoly2 = WktExtensions.MultiPolygonFromWKT("MULTIPOLYGON(((-165.229340 83.874443,-174.766678 80.243286,161.287506 81.645164,176.291473 78.673225,-165.229340 83.874443)))");

            mpoly = GeometryFactory.SplitWorldExtent(mpoly2);

            newmpoly = mpoly.ToWkt();

            Assert.AreEqual("MULTIPOLYGON(((180 80.5496643242432,161.287506 81.645164,176.291473 78.673225,180 79.7170402601565,180 80.5496643242432)),((-165.22934 83.874443,-174.766678 80.243286,-180 80.5496643242432,-180 79.7170402601565,-165.22934 83.874443)))", newmpoly);

            mpoly2 = WktExtensions.MultiPolygonFromWKT("MULTIPOLYGON(((138.141861 83.754265,149.33284 87.420456,-166.712769 84.741585,168.046951 82.234276,138.141861 83.754265)), ((-165.229340 83.874443,-174.766678 80.243286,161.287506 81.645164,176.291473 78.673225,-165.229340 83.874443)))");

            mpoly = GeometryFactory.SplitWorldExtent(mpoly2);

            newmpoly = mpoly.ToWkt();

            Assert.AreEqual("MULTIPOLYGON(((138.141861 83.754265,149.33284 87.420456,180 85.5513966476281,180 83.4216632768107,168.046951 82.234276,138.141861 83.754265)),((-180 85.5513966476281,-166.712769 84.741585,-180 83.4216632768107,-180 85.5513966476281)),((180 80.5496643242432,161.287506 81.645164,176.291473 78.673225,180 79.7170402601565,180 80.5496643242432)),((-165.22934 83.874443,-174.766678 80.243286,-180 80.5496643242432,-180 79.7170402601565,-165.22934 83.874443)))", newmpoly);
        }

    }
}