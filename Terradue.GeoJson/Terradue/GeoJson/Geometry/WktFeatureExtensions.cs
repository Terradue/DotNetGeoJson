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
using System.Linq;
using System.Globalization;

namespace Terradue.GeoJson.Geometry {
    public static class WktFeatureExtensions {

        static readonly IFormatProvider ci = CultureInfo.InvariantCulture;

        public static string ToWkt(this Terradue.GeoJson.Feature.Feature feature) {
             return ToWkt(feature.Geometry);
        }

        public static string ToWkt(this Terradue.GeoJson.Geometry.GeometryObject geometry) {
            if (geometry is Point) {
                string point = GeometryToWktString((Point)geometry);

                return string.Format("POINT({0})", point);
            }

            if (geometry is MultiPoint) {
                string point = GeometryToWktString((MultiPoint)geometry);

                return string.Format("MULTIPOINT{0}", point);
            }

            if (geometry is LineString) {
                string linestring = GeometryToWktString((LineString)geometry);

                return string.Format("LINESTRING{0}", linestring);
            }

            if (geometry is Polygon) {
                string polygon = GeometryToWktString((Polygon)geometry);

                return string.Format("POLYGON{0}", polygon);
            }

            if (geometry is MultiPolygon) {
                string multiPolygon = GeometryToWktString((MultiPolygon)geometry);

                return string.Format("MULTIPOLYGON{0}", multiPolygon);
            }

            return null;
        }

        static string GeometryToWktString(Point point) {
            return GeometryToWktString(point.Position);
        }

        static string GeometryToWktString(MultiPoint multiPoint) {            
            return string.Format("({0})", string.Join(",", multiPoint.Points.Select(GeometryToWktString)));
        }

        static string GeometryToWktString(IPosition position) {

            if (position is GeographicPosition)
                return string.Format(ci, "{0} {1}", ((GeographicPosition)position).Longitude, ((GeographicPosition)position).Latitude);

            return "";
        }

        static string GeometryToWktString(LineString lineString) {          
            return string.Format("({0})", string.Join(",", lineString.Positions.Select(GeometryToWktString)));
        }

        static string GeometryToWktString(Polygon polygon) {            
            return string.Format("({0})", string.Join(",", polygon.LineStrings.Select(GeometryToWktString)));
        }

        static string GeometryToWktString(MultiPolygon multiPolygon) {            
            return string.Format("({0})", string.Join(",", multiPolygon.Polygons.Select(GeometryToWktString)));
        }
    }
}

