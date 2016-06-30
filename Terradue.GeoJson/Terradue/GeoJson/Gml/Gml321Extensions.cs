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
using Terradue.ServiceModel.Ogc.Gml321;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Gml321 {
    public static class Gml321Extensions {

        public static MultiSurfaceType ToGmlMultiSurface(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            if (geometry is Polygon) {
                List<Polygon> polygons = new List<Polygon>();
                polygons.Add((Polygon)geometry);
                MultiPolygon multiPolygon = new MultiPolygon(polygons);

                return ToGmlMultiSurface((MultiPolygon)multiPolygon);
            } else if (geometry is MultiPolygon) {
                return ToGmlMultiSurface((MultiPolygon)geometry);
            } else
                return null;

        }

        public static MultiCurveType ToGmlMultiCurve(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            if (geometry is LineString) {
                List<LineString> lineStrings = new List<LineString>();
                lineStrings.Add((LineString)geometry);
                MultiLineString multiLineString = new MultiLineString(lineStrings);

                return ToGmlMultiCurve((MultiLineString)multiLineString);
            } else if (geometry is MultiLineString) {
                return ToGmlMultiCurve((MultiLineString)geometry);
            } else
                return null;
        }

        public static AbstractGeometryType ToGml(this Terradue.GeoJson.Geometry.GeometryObject geometry) {

            if (geometry is Point) {
                return ToGmlPoint((Point)geometry);
            }

            if (geometry is MultiPoint) {
                return ToGmlMultiPoint((MultiPoint)geometry);
            }

            if (geometry is LineString) {
                return ToGmlLineString((LineString)geometry);
            }

            if (geometry is MultiLineString) {
                return ToGmlMultiCurve((MultiLineString)geometry);
            }

            if (geometry is Polygon) {
                return ToGmlPolygon((Polygon)geometry);
            }

            if (geometry is MultiPolygon) {
                return ToGmlMultiSurface((MultiPolygon)geometry);
            }

            return null;
        }

        public static PointType ToGmlPoint(this Point point) {
            PointType gmlPoint = new PointType();
            var gmlPos = ToGmlPos(point.Position);
            gmlPoint.srsDimension = gmlPos.srsDimension == "2" ? null : gmlPos.srsDimension;
            gmlPoint.Item = gmlPos;
            return gmlPoint;
        }

        public static MultiPointType ToGmlMultiPoint(this MultiPoint multiPoint) {      

            MultiPointType gmlMultiPoint = new MultiPointType();
            List<PointPropertyType> gmlPointMembers = new List<PointPropertyType>();
            foreach (var point in multiPoint.Points) {
                PointPropertyType gmlPointMember = new PointPropertyType();
                gmlPointMember.Point = ToGmlPoint(point);
                gmlPointMembers.Add(gmlPointMember);
            }
            gmlMultiPoint.pointMember = gmlPointMembers.ToArray();
            return gmlMultiPoint;
        }

        public static DirectPositionType ToGmlPos(this IPosition position) {

            if (position is GeographicPosition) {
                DirectPositionType gmlPos = new DirectPositionType();
                gmlPos.srsDimension = ((GeographicPosition)position).Altitude == null ? null : "3";
                GeographicPosition p = (GeographicPosition)position;
                if (p.Altitude != null)
                    gmlPos.Text = string.Format("{0} {1} {2}", p.Latitude, p.Longitude, p.Altitude);
                else
                    gmlPos.Text = string.Format("{0} {1}", p.Latitude, p.Longitude);
                return gmlPos;
            }
            return null;
        }

        public static DirectPositionListType ToGmlPosList(this IPosition[] positions) {

            if (positions.Length > 0 && positions[0] is GeographicPosition) {
                DirectPositionListType gmlPosList = new DirectPositionListType();
                gmlPosList.count = positions.Length.ToString();
                gmlPosList.Text = string.Join(" ", positions.Cast<GeographicPosition>()
                                              .SelectMany<GeographicPosition, string>(p => p.Altitude == null ? new string[2] {
                    p.Latitude.ToString(),
                    p.Longitude.ToString()
                } : new string[3] {
                    p.Latitude.ToString(),
                    p.Longitude.ToString(),
                    p.Altitude.ToString()
                }).ToArray());
                gmlPosList.srsDimension = ((GeographicPosition)positions[0]).Altitude == null ? null : "3";
                return gmlPosList;
            }
            return null;
        }

        public static LineStringType ToGmlLineString(this LineString lineString) {  

            LineStringType gmlLineString = new LineStringType();
            gmlLineString.ItemsElementName = new ItemsChoiceType[1];
            gmlLineString.ItemsElementName[0] = ItemsChoiceType.posList;
            gmlLineString.Items = new object[1];
            gmlLineString.Items[0] = ToGmlPosList(lineString.Positions.ToArray());
            return gmlLineString;
        }

        public static LinearRingType ToGmlLinearRing(this LineString lineString) {  

            if (!lineString.IsClosed())
                throw new InvalidFormatException("LineString geometry is not closed and cannot be transformed to GML linearRing");

            LinearRingType gmlLineString = new LinearRingType();
            gmlLineString.ItemsElementName = new ItemsChoiceType6[1];
            gmlLineString.ItemsElementName[0] = ItemsChoiceType6.posList;
            gmlLineString.Items = new object[1];
            gmlLineString.Items[0] = ToGmlPosList(lineString.Positions.ToArray());
            return gmlLineString;
        }

        public static MultiCurveType ToGmlMultiCurve(this MultiLineString multiLineString) {  

            MultiCurveType gmlMultiLineString = new MultiCurveType();
            gmlMultiLineString.curveMembers = new CurveArrayPropertyType();
            List<LineStringType> gmlLineStrings = new List<LineStringType>();
            foreach (var lineString in multiLineString.LineStrings) {
                gmlLineStrings.Add(ToGmlLineString(lineString));
            }
            gmlMultiLineString.curveMembers.Items = gmlLineStrings.ToArray();
            return gmlMultiLineString;
        }

        public static PolygonType ToGmlPolygon(this Polygon polygon) {  
            PolygonType gmlPolygon = new PolygonType();
            if (polygon.LineStrings.Count > 0) {
                gmlPolygon.exterior = new AbstractRingPropertyType();
                gmlPolygon.exterior.Item = ToGmlLinearRing(polygon.LineStrings[0]);
                if (polygon.LineStrings.Count > 1) {
                    var interiors = new List<AbstractRingPropertyType>();
                    foreach (var lineString in polygon.LineStrings.Take(1)) {
                        var interior = new AbstractRingPropertyType();
                        interior.Item = ToGmlLinearRing(lineString);
                        interiors.Add(interior);
                    }
                    gmlPolygon.interior = interiors.ToArray();
                }
            }

            return gmlPolygon;
        }

        public static MultiSurfaceType ToGmlMultiSurface(this MultiPolygon multiPolygon) {            
            MultiSurfaceType gmlMultiSurface = new MultiSurfaceType();
            gmlMultiSurface.surfaceMembers = new SurfaceArrayPropertyType();
            gmlMultiSurface.surfaceMembers.Items = multiPolygon.Polygons.Select<Polygon, PolygonType>(p => p.ToGmlPolygon()).ToArray();

            return gmlMultiSurface;
        }

        public static GeometryObject ToGeometry(this AbstractGeometryType gmlObject) {

            if (gmlObject == null) {
                throw new ArgumentNullException("gmlObject");
            }

            if (gmlObject is MultiCurveType) {
                return ((MultiCurveType)gmlObject).ToGeometry();
            }

            if (gmlObject is MultiSurfaceType) {
                return ((MultiSurfaceType)gmlObject).ToGeometry();
            }

            if (gmlObject is MultiPointType) {
                return ((MultiPointType)gmlObject).ToGeometry();
            }

            throw new NotImplementedException(gmlObject.GetType().ToString());

        }

        public static MultiPolygon ToGeometry(this MultiSurfaceType gmlMultiSurface) {
            List<Polygon> polygons = new List<Polygon>();

            if (gmlMultiSurface.surfaceMember != null) {

                foreach (var member in gmlMultiSurface.surfaceMember) {

                    if (member.Item is PolygonType) {
                        polygons.Add(((PolygonType)member.Item).ToGeometry());
                        continue;
                    }

                    throw new NotImplementedException();
                }
            }

            if (gmlMultiSurface.surfaceMembers != null) {

                foreach (var member in gmlMultiSurface.surfaceMembers.Items) {

                    if (member is PolygonType) {
                        polygons.Add(((PolygonType)member).ToGeometry());
                        continue;
                    }

                    throw new NotImplementedException();
                }
            }

            return new MultiPolygon(polygons);
        }

        public static MultiLineString ToGeometry(this MultiCurveType gmlMultiCurve) {
            List<LineString> linestrings = new List<LineString>();

            if (gmlMultiCurve.curveMember != null) {

                foreach (var member in gmlMultiCurve.curveMember) {
                    if (member.Item is LineStringType) {
                        linestrings.Add(((LineStringType)member.Item).ToGeometry());
                        continue;
                    }

                    throw new NotImplementedException();
                }
            }

            if (gmlMultiCurve.curveMembers != null) {

                foreach (var member in gmlMultiCurve.curveMembers.Items) {
                    if (member is LineStringType) {
                        linestrings.Add(((LineStringType)member).ToGeometry());
                        continue;
                    }

                    throw new NotImplementedException();
                }
            }

            return new MultiLineString(linestrings);
        }

        public static MultiPoint ToGeometry(this MultiPointType gmlMultipoint) {
            List<IPosition> points = new List<IPosition>();

            if (gmlMultipoint.pointMember != null) {

                foreach (var member in gmlMultipoint.pointMember) {

                    points.Add(member.Point.ToGeometry().Position);

                }
            }

            if (gmlMultipoint.pointMembers != null) {

                foreach (var member in gmlMultipoint.pointMembers.Point) {

                    points.Add(member.ToGeometry().Position);
                }
            }

            return new MultiPoint(points);
        }

        public static Polygon ToGeometry(this PolygonType gmlPolygon) {
            List<LineString> polygon = new List<LineString>();
            LineString ls = null;

            if (gmlPolygon.exterior != null) {

                AbstractRingPropertyType arpt = (AbstractRingPropertyType)gmlPolygon.exterior;


                if (arpt.Item is LinearRingType) {
                    ls = ((LinearRingType)arpt.Item).ToGeometry();

                    if (ls.Positions.Count < 4 || !ls.IsClosed())
                        throw new InvalidFormatException("invalid GML representation: polygon outer is not a closed ring of minimum 4 positions");
                }
            }

            if (ls == null)
                throw new InvalidFormatException("invalid GML representation: polygon outer is empty");

            polygon.Add(ls);


            if (gmlPolygon.interior != null) {
                foreach (AbstractRingPropertyType arpt in gmlPolygon.interior) {

                    if (arpt.Item is LinearRingType) {
                        ls = ((LinearRingType)arpt.Item).ToGeometry();

                        if (ls.Positions.Count < 4 || !ls.IsClosed())
                            throw new InvalidFormatException("invalid GML representation: polygon inner is not a closed ring of minimum 4 positions");
                    }

                    polygon.Add(ls);
                }
            }

            return new Polygon(polygon);
        }

        public static LineString ToGeometry(this LinearRingType linearRing) {
            List<IPosition> positions;

            Type posType = linearRing.ItemsElementName.First().GetType();

            positions = FromGMLData(linearRing.Items, Array.ConvertAll<ItemsChoiceType6, string>(linearRing.ItemsElementName, i => i.ToString()));

            LineString linestring = new LineString(positions);

            if (linestring.Positions.Count < 4 || !linestring.IsClosed())
                throw new InvalidFormatException("invalid GML representation: linearring is not a closed ring of minimum 4 positions");

            return linestring;
        }

        public static LineString ToGeometry(this LineStringType lineString) {
            if (lineString.Items == null)
                return null;

            List<IPosition> points = FromGMLData(lineString.Items, Array.ConvertAll<ItemsChoiceType, string>(lineString.ItemsElementName, i => i.ToString()));

            if (points.Count < 2)
                throw new InvalidFormatException("invalid GML representation: LineString type must have at least 2 positions");

            return new LineString(points);
        }

        public static IPosition ToGeometry(this DirectPositionType pos) {
            IPosition position;

            int dim;

            string[] coord = pos.Text.Trim().Replace("  ", " ").Split(' ');
            if (string.IsNullOrEmpty(pos.srsDimension))
                dim = 2; /* We assume that we are in 2D */
            else {
                dim = int.Parse(pos.srsDimension);
                if (dim < 2 || dim > 3)
                    throw new InvalidFormatException("invalid GML representation: gml:pos dimension equals " + dim);
            }

            if (dim == 2)
                position = new GeographicPosition(coord[0], coord[1]);
            else
                position = new GeographicPosition(coord[0], coord[1], coord[2]);
            return position;
        }

        public static List<IPosition> ToGeometry(this DirectPositionListType pos) {
            List<IPosition> positions = new List<IPosition>();
            int dim;

			string[] coord = pos.Text.Trim().Replace("  ", " ").Split(' ');

            if (string.IsNullOrEmpty(pos.srsDimension))
                dim = 2; /* We assume that we are in 2D */
            else {
                dim = int.Parse(pos.srsDimension);
                if (dim < 2 || dim > 3)
                    throw new InvalidFormatException("invalid GML representation: gml:pos dimension equals " + dim);
            }

            for (int i = 0; i < coord.Count(); i += dim) {
                if (dim == 2)
                    positions.Add(new GeographicPosition(coord[i + 0], coord[i + 1], null));
                if (dim == 3)
                    positions.Add(new GeographicPosition(coord[i + 0], coord[i + 1], coord[i + 2]));
            }
            return positions;
        }

        public static List<IPosition> ToGeometry(this CoordinatesType coordinates) {

            List<IPosition> positions = new List<IPosition>();
            string gmlcoord, gmlts, gmlcs, gmldec;
            char ts = ' ', cs = ',', dec = '.';

            /* Retrieve separator between coordinates tuples */
            gmlts = coordinates.ts;
            if (char.TryParse(gmlts, out ts) != true)
                ts = ' ';

            /* Retrieve separator between each coordinate */
            gmlcs = coordinates.cs;
            if (char.TryParse(gmlcs, out cs) != true) {
                cs = ',';
            }

            /* Retrieve decimal separator */
            gmldec = coordinates.@decimal;
            if (char.TryParse(gmldec, out dec) != true)
                dec = '.';

            if (cs == ts || cs == dec || ts == dec)
                throw new InvalidFormatException("invalid GML representation: gml:coordinates ambiguity in separators");

            /* We retrieve gml:coord string */
            gmlcoord = coordinates.Value.Trim().Replace("  ", " ");
            if (string.IsNullOrEmpty(gmlcoord))
                throw new InvalidFormatException("invalid GML representation: gml:coordinates is empty");

            string[] coordinates1 = gmlcoord.Split(ts);

            foreach (string coord in coordinates1) {
                string[] pos = coord.Split(cs);
                try {

                    double x = double.Parse(pos[1]);
                    double y = double.Parse(pos[0]);
                    double? z = null;
                    if (pos.Length > 2)
                        z = double.Parse(pos[2]);

                    positions.Add(new GeographicPosition(y, x, z));
                } catch (FormatException e) {
                    throw new InvalidFormatException(string.Format("invalid GML coordinate representation: \"{0}\" X={1}, Y={2}", coord, pos[1], pos[0]));
                }

            }
            return positions;

        }


        public static Point ToGeometry(this PointType point) {

            if (point.Item is DirectPositionType)
                return new Point(((DirectPositionType)point.Item).ToGeometry());
            if (point.Item is CoordinatesType)
                return new Point(((CoordinatesType)point.Item).ToGeometry().First());

            throw new InvalidFormatException("invalid GML representation: gml:point is empty");
        }

        private static List<IPosition> FromGMLData(object[] items, string[] itemsType) {

            List<IPosition> positions = new List<IPosition>();

            for (int i = 0; i < items.Count(); i++) {

                switch (itemsType[i]) {

                    case "pos":
                        positions.Add(((DirectPositionType)items[i]).ToGeometry());
                        break;
                    case "posList":
                        positions.AddRange(((DirectPositionListType)items[i]).ToGeometry());
                        break;
                    case "coordinates":
                        positions.AddRange(((CoordinatesType)items[i]).ToGeometry());
                        break;
                    case "pointRep":
                    case "pointProperty":
                        positions.Add(((PointPropertyType)items[i]).Point.ToGeometry().Position);
                        break;
                }

            }

            return positions;

        }
    }
}

