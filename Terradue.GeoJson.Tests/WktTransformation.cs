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

            Terradue.GeoJson.Feature.PointFeature pointf = new Terradue.GeoJson.Feature.PointFeature(new Terradue.GeoJson.Geometry.Point(Position1));
            string wkt = pointf.ToWkt();
            Assert.AreEqual("POINT(124 10)", wkt);

        }

        [Test()]
        public void LineStringFeatureToWkt() {

            Terradue.GeoJson.Feature.LineStringFeature linestringf = 
                new Terradue.GeoJson.Feature.LineStringFeature(new Terradue.GeoJson.Geometry.LineString(
                    new List<IPosition>(){ Position1, Position2, Position3 }));
            string wkt = linestringf.ToWkt();
            Assert.AreEqual("LINESTRING(124 10,124 11,125 10)", wkt);

        }

        [Test()]
        public void PolygonFeatureToWkt() {

            List<LineString> list = new List<LineString>();
            list.Add(new Terradue.GeoJson.Geometry.LineString(
                                        new List<IPosition>(){ Position1, Position2, Position3, Position4 }));

            Terradue.GeoJson.Feature.PolygonFeature polygonf = 
                new Terradue.GeoJson.Feature.PolygonFeature(new Polygon(list));
            string wkt = polygonf.ToWkt();
            Assert.AreEqual("POLYGON((124 10,124 11,125 10,124 10))", wkt);

        }
    }
}

