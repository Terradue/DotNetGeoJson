//
//  FeatureExtensions.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
using System;
using Terradue.GeoJson.Feature;

namespace Terradue.GeoJson.Geometry {
    public static class FeatureExtensions {

        public static string ToWkt(this Terradue.GeoJson.Feature.Feature feature)
        {
            if (feature is PointFeature) {
                return PointFeatureToWkt((PointFeature)feature);
            }

            if (feature is MultiPointFeature) {
                return MultiPointFeatureToWkt((MultiPointFeature)feature);
            }

            if (feature is LineStringFeature) {
                return LineStringFeatureToWkt((LineStringFeature)feature);
            }

            if (feature is PolygonFeature) {
                return PolygonFeatureToWkt((PolygonFeature)feature);
            }

            if (feature is MultiPolygonFeature) {
                return MultiPolygonFeatureToWkt((MultiPolygonFeature)feature);
            }

            return null;
        }

        static string PointFeatureToWkt(PointFeature pointFeature) {

            string point = GeometryToWktString(pointFeature.Geometry);

            return string.Format("POINT({0})", point);

        }

        static string MultiPointFeatureToWkt(MultiPointFeature multiPointFeature) {

            string point = GeometryToWktString(multiPointFeature.Geometry);

            return string.Format("MULTIPOINT({0})", point);
        }

        static string LineStringFeatureToWkt(LineStringFeature lineStringFeature) {

            string linestring = GeometryToWktString(lineStringFeature.Geometry);

            return string.Format("LINESTRING({0})", linestring);
        }

        static string PolygonFeatureToWkt(PolygonFeature polygonFeature) {

            string polygon = GeometryToWktString(polygonFeature.Geometry);

            return string.Format("POLYGON({0})", polygon);
        }

        static string MultiPolygonFeatureToWkt(MultiPolygonFeature multiPolygonFeature) {

            string multiPolygon = GeometryToWktString(multiPolygonFeature.Geometry);

            return string.Format("MULTIPOLYGON({0})", multiPolygon);
        }

        static string GeometryToWktString(Point point) {

            return GeometryToWktString(point.Position);

        }

        static string GeometryToWktString(MultiPoint multiPoint) {

            string multiPointWkt = "";
            string sep = "";
            foreach (var polygon in multiPoint.Points) {
                multiPointWkt += sep + GeometryToWktString(polygon);
                sep = ",";
            }

            return multiPointWkt;

        }

        static string GeometryToWktString(IPosition position) {

            if ( position is GeographicPosition)
                return string.Format("{0} {1}", ((GeographicPosition)position).Longitude, ((GeographicPosition)position).Latitude);

            return "";
        }

        static string GeometryToWktString(LineString lineString) {

            string linestring = "";
            string sep = "";
            foreach (var position in lineString.Positions) {
                linestring += sep + GeometryToWktString(position);
                sep = ",";
            }

            return linestring;

        }

        static string GeometryToWktString(Polygon polygon) {

            string polygonWkt = "";
            foreach (var linestring in polygon.LineStrings) {
                polygonWkt += "(" + GeometryToWktString(linestring) + ")";
            }

            return polygonWkt;

        }

        static string GeometryToWktString(MultiPolygon multiPolygon) {

            string multiPolygonWkt = "";
            foreach (var polygon in multiPolygon.Polygons) {
                multiPolygonWkt += "(" + GeometryToWktString(polygon) + ")";
            }

            return multiPolygonWkt;

        }
    }
}

