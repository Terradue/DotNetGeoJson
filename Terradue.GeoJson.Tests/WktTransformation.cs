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

            var geometry = GeometryFactory.WktToGeometry("POLYGON((-5.361328125 36.03133177633189,-4.921875 36.80928470205937,-2.021484375 36.949891786813296,3.076171875 42.553080288955826,4.21875 43.51668853502909,8.4375 44.5278427984555,13.095703125 45.89000815866182,19.248046875 42.09822241118974,26.71875 39.707186656826565,35.947265625 36.5978891330702,34.1015625 31.203404950917395,18.984375 30.29701788337205,-5.361328125 36.03133177633189))");

            GeometryFactory.SplitWorldExtent((Polygon)geometry);

            string geomstring = geometry.ToWkt();

            var feature = GeometryFactory.WktToFeature("POLYGON((-5.361328125 36.03133177633189,-4.921875 36.80928470205937,-2.021484375 36.949891786813296,3.076171875 42.553080288955826,4.21875 43.51668853502909,8.4375 44.5278427984555,13.095703125 45.89000815866182,19.248046875 42.09822241118974,26.71875 39.707186656826565,35.947265625 36.5978891330702,34.1015625 31.203404950917395,18.984375 30.29701788337205,-5.361328125 36.03133177633189))");

        }
    }
}

