using NUnit.Framework;
using System;
using Terradue.GeoJson.Geometry;
using System.Collections.Generic;

namespace Terradue.GeoJson.Tests {

    [TestFixture()]
    public class WktTransformation {

        GeographicPosition Position1 = new GeographicPosition(10, 124);
        GeographicPosition Position2 = new GeographicPosition(11, 124);
        GeographicPosition Position3 = new GeographicPosition(10, 125);
        GeographicPosition Position4 = new GeographicPosition(10, 124);


        [Test()]
        public void PointFeatureToWkt() {

            Terradue.GeoJson.Feature.Feature pointf = new Terradue.GeoJson.Feature.Feature(new Terradue.GeoJson.Geometry.Point(Position1), null);
            string wkt = pointf.ToWkt();
            Assert.AreEqual("POINT(124 10)", wkt);

        }

        [Test()]
        public void LineStringFeatureToWkt() {

            Terradue.GeoJson.Feature.Feature linestringf = 
                new Terradue.GeoJson.Feature.Feature(new Terradue.GeoJson.Geometry.LineString(
                    new List<IPosition>(){ Position1, Position2, Position3 }), null);
            string wkt = linestringf.ToWkt();
            Assert.AreEqual("LINESTRING(124 10,124 11,125 10)", wkt);

        }

        [Test()]
        public void PolygonFeatureToWkt() {

            List<LineString> list = new List<LineString>();
            list.Add(new Terradue.GeoJson.Geometry.LineString(
                                        new List<IPosition>(){ Position1, Position2, Position3, Position4 }));

            Terradue.GeoJson.Feature.Feature polygonf = 
                new Terradue.GeoJson.Feature.Feature(new Polygon(list), null);
            string wkt = polygonf.ToWkt();
            Assert.AreEqual("POLYGON((124 10,124 11,125 10,124 10))", wkt);

        }
    }
}

