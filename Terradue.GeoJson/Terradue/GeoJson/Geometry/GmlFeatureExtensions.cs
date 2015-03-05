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
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Geometry {
    public static class GmlFeatureExtensions {

        static readonly IFormatProvider ci = CultureInfo.InvariantCulture;
        static XmlSerializer GmlPointSerializer = new XmlSerializer(typeof(Terradue.GeoJson.Gml.PointType));
        static XmlSerializer GmlMultiPointSerializer = new XmlSerializer(typeof(Terradue.GeoJson.Gml.MultiPointType));
        static XmlSerializer GmlLineStringSerializer = new XmlSerializer(typeof(Terradue.GeoJson.Gml.LineStringType));
        static XmlSerializer GmlMultiLineStringSerializer = new XmlSerializer(typeof(Terradue.GeoJson.Gml.MultiCurveType));
        static XmlSerializer GmlPolygonSerializer = new XmlSerializer(typeof(Terradue.GeoJson.Gml.PolygonType));
        static XmlSerializer GmlMultiSurfaceSerializer = new XmlSerializer(typeof(Terradue.GeoJson.Gml.MultiSurfaceType));

        public static XmlElement ToMultiCurveGml(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            XmlDocument xdoc = new XmlDocument();

            using (XmlWriter writer = xdoc.CreateNavigator().AppendChild()) {

                if (geometry is LineString) {
                    List<LineString> lineStrings = new List<LineString>();
                    lineStrings.Add((LineString)geometry);
                    MultiLineString multiLineString = new MultiLineString(lineStrings);

                    GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiLineString)multiLineString));
                } else if (geometry is MultiLineString) {
                    GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiLineString)geometry));
                } else
                    return null;
            }

            return xdoc.DocumentElement;
        }

        public static XmlElement ToMultiSurfaceGml(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            XmlDocument xdoc = new XmlDocument();

            using (XmlWriter writer = xdoc.CreateNavigator().AppendChild()) {

                if (geometry is Polygon) {
                    List<Polygon> polygons = new List<Polygon>();
                    polygons.Add((Polygon)geometry);
                    MultiPolygon multiPolygon = new MultiPolygon(polygons);

                    GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiPolygon)multiPolygon));
                } else if (geometry is MultiPolygon) {
                    GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiPolygon)geometry));
                } else
                    return null;
            }

            return xdoc.DocumentElement;
        }

        public static Terradue.GeoJson.Gml.MultiSurfaceType ToMultiSurface(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            if (geometry is Polygon) {
                List<Polygon> polygons = new List<Polygon>();
                polygons.Add((Polygon)geometry);
                MultiPolygon multiPolygon = new MultiPolygon(polygons);

                return GeometryToGml((MultiPolygon)multiPolygon);
            } else if (geometry is MultiPolygon) {
                return GeometryToGml((MultiPolygon)geometry);
            } else
                return null;

        }

        public static Terradue.GeoJson.Gml.MultiCurveType ToMultiCurve(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

                if (geometry is LineString) {
                    List<LineString> lineStrings = new List<LineString>();
                    lineStrings.Add((LineString)geometry);
                    MultiLineString multiLineString = new MultiLineString(lineStrings);

                    return GeometryToGml((MultiLineString)multiLineString);
                } else if (geometry is MultiLineString) {
                    return GeometryToGml((MultiLineString)geometry);
                } else
                    return null;
        }

        public static XmlElement ToGml(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            XmlDocument xdoc = new XmlDocument();

            using (XmlWriter writer = xdoc.CreateNavigator().AppendChild()) {

                if (geometry is Point) {
                    GmlPointSerializer.Serialize(writer, GeometryToGml((Point)geometry));
                }

                if (geometry is MultiPoint) {
                    GmlMultiPointSerializer.Serialize(writer, GeometryToGml((MultiPoint)geometry));
                }

                if (geometry is LineString) {
                    GmlLineStringSerializer.Serialize(writer, GeometryToGml((LineString)geometry));
                }

                if (geometry is MultiLineString) {
                    GmlMultiLineStringSerializer.Serialize(writer, GeometryToGml((MultiLineString)geometry));
                }

                if (geometry is Polygon) {
                    GmlPolygonSerializer.Serialize(writer, GeometryToGml((Polygon)geometry));
                }

                if (geometry is MultiPolygon) {
                    GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiPolygon)geometry));
                }
            }

            return xdoc.DocumentElement;
        }

        public static Terradue.GeoJson.Gml.PointType PointFeatureToGml(PointFeature pointFeature) {

            return GeometryToGml(pointFeature.Geometry);
        }

        public static Terradue.GeoJson.Gml.MultiPointType MultiPointFeatureToGml(MultiPointFeature multiPointFeature) {

            return GeometryToGml(multiPointFeature.Geometry);
        }

        public static Terradue.GeoJson.Gml.LineStringType LineStringFeatureToGml(LineStringFeature lineStringFeature) {

            return GeometryToGml(lineStringFeature.Geometry);
        }

        public static Terradue.GeoJson.Gml.PolygonType PolygonFeatureToGml(PolygonFeature polygonFeature) {

            return GeometryToGml(polygonFeature.Geometry);
        }

        public static Terradue.GeoJson.Gml.MultiSurfaceType MultiPolygonFeatureToGml(MultiPolygonFeature multiPolygonFeature) {

            return GeometryToGml(multiPolygonFeature.Geometry);
        }

        public static Terradue.GeoJson.Gml.PointType GeometryToGml(Point point) {
            Terradue.GeoJson.Gml.PointType gmlPoint = new Terradue.GeoJson.Gml.PointType();
            var gmlPos = GeometryToGml(point.Position);
            gmlPoint.srsDimension = gmlPos.srsDimension;
            gmlPoint.Item = gmlPos;
            return gmlPoint;
        }

        public static Terradue.GeoJson.Gml.MultiPointType GeometryToGml(MultiPoint multiPoint) {      

            Terradue.GeoJson.Gml.MultiPointType gmlMultiPoint = new Terradue.GeoJson.Gml.MultiPointType();
            List<Terradue.GeoJson.Gml.PointPropertyType> gmlPointMembers = new List<Terradue.GeoJson.Gml.PointPropertyType>();
            foreach (var point in multiPoint.Points) {
                Terradue.GeoJson.Gml.PointPropertyType gmlPointMember = new Terradue.GeoJson.Gml.PointPropertyType();
                gmlPointMember.Point = GeometryToGml(point);
                gmlPointMembers.Add(gmlPointMember);
            }
            gmlMultiPoint.pointMember = gmlPointMembers.ToArray();
            return gmlMultiPoint;
        }

        public static Terradue.GeoJson.Gml.DirectPositionType GeometryToGml(IPosition position) {

            if (position is GeographicPosition) {
                Terradue.GeoJson.Gml.DirectPositionType gmlPos = new Terradue.GeoJson.Gml.DirectPositionType();
                gmlPos.srsDimension = ((GeographicPosition)position).Altitude == null ? "2" : "3";
                GeographicPosition p = (GeographicPosition)position;
                gmlPos.Text = string.Format("{0} {1}{2}", p.Latitude, p.Longitude, p.Altitude == null ? "" : " " + p.Altitude);
                return gmlPos;
            }
            return null;
        }

        public static Terradue.GeoJson.Gml.DirectPositionListType GeometryToGml(IPosition[] positions) {

            if (positions.Length > 0 && positions[0] is GeographicPosition) {
                Terradue.GeoJson.Gml.DirectPositionListType gmlPosList = new Terradue.GeoJson.Gml.DirectPositionListType();
                gmlPosList.count = positions.Length.ToString();
                gmlPosList.Text = string.Join(" ", positions.Cast<GeographicPosition>().Select<GeographicPosition, string>(p => string.Format("{0} {1}{2}", p.Latitude, p.Longitude, p.Altitude == null ? "" : " " + p.Altitude)));
                gmlPosList.srsDimension = ((GeographicPosition)positions[0]).Altitude == null ? "2" : "3";
                return gmlPosList;
            }
            return null;
        }

        public static Terradue.GeoJson.Gml.LineStringType GeometryToGml(LineString lineString) {  

            Terradue.GeoJson.Gml.LineStringType gmlLineString = new Terradue.GeoJson.Gml.LineStringType();
            gmlLineString.ItemsElementName = new Terradue.GeoJson.Gml.ItemsChoiceType[1];
            gmlLineString.ItemsElementName[0] = Terradue.GeoJson.Gml.ItemsChoiceType.posList;
            gmlLineString.Items = new object[1];
            gmlLineString.Items[0] = GeometryToGml(lineString.Positions.ToArray());
            return gmlLineString;
        }

        public static Terradue.GeoJson.Gml.MultiCurveType GeometryToGml(MultiLineString multiLineString) {  

            Terradue.GeoJson.Gml.MultiCurveType gmlMultiLineString = new Terradue.GeoJson.Gml.MultiCurveType();
            gmlMultiLineString.curveMembers = new Terradue.GeoJson.Gml.CurveArrayPropertyType();
            List<Terradue.GeoJson.Gml.LineStringType> gmlLineStrings = new List<Terradue.GeoJson.Gml.LineStringType>();
            foreach (var lineString in multiLineString.LineStrings) {
                gmlLineStrings.Add(GeometryToGml(lineString));
            }
            gmlMultiLineString.curveMembers.Items = gmlLineStrings.ToArray();
            return gmlMultiLineString;
        }

        public static Terradue.GeoJson.Gml.PolygonType GeometryToGml(Polygon polygon) {  
            Terradue.GeoJson.Gml.PolygonType gmlPolygon = new Terradue.GeoJson.Gml.PolygonType();
            if (polygon.LineStrings.Count > 0) {
                var exterior = new Terradue.GeoJson.Gml.AbstractRingPropertyType();
                gmlPolygon.exterior = exterior;
                var linearRing = new Terradue.GeoJson.Gml.LinearRingType();
                exterior.Item = linearRing;
                linearRing.ItemsElementName = new Terradue.GeoJson.Gml.ItemsChoiceType6[1];
                linearRing.ItemsElementName[0] = Terradue.GeoJson.Gml.ItemsChoiceType6.posList;
                linearRing.Items = new object[1];
                linearRing.Items[0] = GeometryToGml(polygon.LineStrings[0].Positions.ToArray());
                if (polygon.LineStrings.Count > 1) {
                    var interiors = new List<Terradue.GeoJson.Gml.AbstractRingPropertyType>();
                    foreach (var lineString in polygon.LineStrings.Take(1)) {
                        var interior = new Terradue.GeoJson.Gml.AbstractRingPropertyType();
                        linearRing = new Terradue.GeoJson.Gml.LinearRingType();
                        exterior.Item = linearRing;
                        linearRing = new Terradue.GeoJson.Gml.LinearRingType();
                        linearRing.ItemsElementName = new Terradue.GeoJson.Gml.ItemsChoiceType6[1];
                        linearRing.ItemsElementName[0] = Terradue.GeoJson.Gml.ItemsChoiceType6.posList;
                        linearRing.Items = new object[1];
                        linearRing.Items[0] = GeometryToGml(lineString.Positions.ToArray());
                        interiors.Add(interior);
                    }
                    gmlPolygon.interior = interiors.ToArray();
                }
            }

            return gmlPolygon;
        }

        public static Terradue.GeoJson.Gml.MultiSurfaceType GeometryToGml(MultiPolygon multiPolygon) {            
            Terradue.GeoJson.Gml.MultiSurfaceType gmlMultiSurface = new Terradue.GeoJson.Gml.MultiSurfaceType();
            gmlMultiSurface.surfaceMembers = new Terradue.GeoJson.Gml.SurfaceArrayPropertyType();
            List<Terradue.GeoJson.Gml.PolygonType> gmlPolygons = new List<Terradue.GeoJson.Gml.PolygonType>();
            foreach (var polygon in multiPolygon.Polygons) {
                gmlPolygons.Add(GeometryToGml(polygon));
            }
            gmlMultiSurface.surfaceMembers.Items = gmlPolygons.ToArray();

            return gmlMultiSurface;
        }
    }
}

