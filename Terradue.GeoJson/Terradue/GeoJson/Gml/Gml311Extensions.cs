﻿//
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
using System.Collections.Generic;
using System.Linq;
using Terradue.GeoJson.Geometry;
using Terradue.ServiceModel.Ogc.Gml311;

namespace Terradue.GeoJson.Gml311 {
    public static class Gml311Extensions {

        public static MultiSurfaceType ToGmlMultiSurface(this GeometryObject geometry)
        {
          if (geometry is Polygon) {
                var polygons = new List<Polygon>();
                polygons.Add((Polygon)geometry);
                var multiPolygon = new MultiPolygon(polygons);

                return ToGmlMultiSurface(multiPolygon);
            }
          if (geometry is MultiPolygon) {
            return ToGmlMultiSurface((MultiPolygon)geometry);
          }
          return null;
        }

        public static MultiCurveType ToGmlMultiCurve(this GeometryObject geometry)
        {
          if (geometry is LineString) {
                var lineStrings = new List<LineString>();
                lineStrings.Add((LineString)geometry);
                var multiLineString = new MultiLineString(lineStrings);

                return ToGmlMultiCurve(multiLineString);
            }
          if (geometry is MultiLineString) {
            return ToGmlMultiCurve((MultiLineString)geometry);
          }
          return null;
        }

        public static AbstractGeometryType ToGml(this GeometryObject geometry) {

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
                return ToGmlMultiLineString((MultiLineString)geometry);
            }

            if (geometry is Polygon) {
                return ToGmlPolygon((Polygon)geometry);
            }

            if (geometry is MultiPolygon) {
                return ToGmlMultiPolygon((MultiPolygon)geometry);
            }

            return null;
        }

        public static PointType ToGmlPoint(this Point point) {
            var gmlPoint = new PointType();
            var gmlPos = ToGmlPos(point.Position);
            gmlPoint.srsDimension = gmlPos.srsDimension == "2" ? null : gmlPos.srsDimension;
            gmlPoint.Item = gmlPos;
            return gmlPoint;
        }

        public static MultiPointType ToGmlMultiPoint(this MultiPoint multiPoint) {      

            var gmlMultiPoint = new MultiPointType();
            var gmlPointMembers = new List<PointPropertyType>();
            foreach (var point in multiPoint.Points) {
                var gmlPointMember = new PointPropertyType();
                gmlPointMember.Point = ToGmlPoint(point);
                gmlPointMembers.Add(gmlPointMember);
            }
            gmlMultiPoint.pointMember = gmlPointMembers.ToArray();
            return gmlMultiPoint;
        }

        public static DirectPositionType ToGmlPos(this IPosition position) {

            if (position is GeographicPosition) {
                var gmlPos = new DirectPositionType();
                gmlPos.srsDimension = ((GeographicPosition)position).Altitude == null ? null : "3";
                var p = (GeographicPosition)position;
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
                var gmlPosList = new DirectPositionListType();
                gmlPosList.count = positions.Length.ToString();
                gmlPosList.Text = string.Join(" ", positions.Cast<GeographicPosition>()
                    .SelectMany(p => p.Altitude == null ? new string[2] {
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

            var gmlLineString = new LineStringType();
            gmlLineString.Items1ElementName = new Items1ChoiceType1[1];
            gmlLineString.Items1ElementName[0] = Items1ChoiceType1.posList;
            gmlLineString.Items1 = new object[1];
            gmlLineString.Items1[0] = ToGmlPosList(lineString.Positions.ToArray());
            return gmlLineString;
        }

        public static LinearRingType ToGmlLinearRing(this LineString lineString) {  

            if (!lineString.IsClosed())
                throw new InvalidFormatException("LineString geometry is not closed and cannot be transformed to GML linearRing");
            
            var gmlLineString = new LinearRingType();
            gmlLineString.Items1ElementName = new Items1ChoiceType2[1];
            gmlLineString.Items1ElementName[0] = Items1ChoiceType2.posList;
            gmlLineString.Items1 = new object[1];
            gmlLineString.Items1[0] = ToGmlPosList(lineString.Positions.ToArray());
            return gmlLineString;
        }

        public static MultiCurveType ToGmlMultiCurve(this MultiLineString multiLineString) {  

            var gmlMultiLineString = new MultiCurveType();
            gmlMultiLineString.curveMembers = new AbstractCurveType[multiLineString.LineStrings.Count];
            var gmlLineStrings = new List<LineStringType>();
            foreach (var lineString in multiLineString.LineStrings) {
                gmlLineStrings.Add(ToGmlLineString(lineString));
            }
            gmlMultiLineString.curveMembers = gmlLineStrings.ToArray();
            return gmlMultiLineString;
        }

        public static MultiLineStringType ToGmlMultiLineString(this MultiLineString multiLineString) {  

            var gmlMultiLineString = new MultiLineStringType();
            var gmlLineStrings = new List<LineStringPropertyType>();
            foreach (var lineString in multiLineString.LineStrings) {
                var lspt = new LineStringPropertyType();
                lspt.LineString = ToGmlLineString(lineString);
                gmlLineStrings.Add(lspt);
            }
            gmlMultiLineString.lineStringMember = gmlLineStrings.ToArray();
            return gmlMultiLineString;
        }

        public static MultiPolygonType ToGmlMultiPolygon(this MultiPolygon multiPolygon) {  

            var gmlMultiPolygon = new MultiPolygonType();
            var gmlPolygons = new List<PolygonPropertyType>();
            foreach (var polygon in multiPolygon.Polygons) {
                var ppt = new PolygonPropertyType();
                ppt.Polygon = ToGmlPolygon(polygon);
                gmlPolygons.Add(ppt);
            }
            gmlMultiPolygon.polygonMember = gmlPolygons.ToArray();
            return gmlMultiPolygon;
        }

        public static PolygonType ToGmlPolygon(this Polygon polygon) {  
            var gmlPolygon = new PolygonType();
            if (polygon.LineStrings.Count > 0) {
                var exterior = new AbstractRingPropertyType();
                gmlPolygon.Item = exterior;
                gmlPolygon.ItemElementName = ItemChoiceType5.exterior;
				if (!polygon.LineStrings[0].IsClosed()) {
					polygon.LineStrings[0].Positions.Add(polygon.LineStrings[0].Positions[0]);
				}
                exterior.Item = ToGmlLinearRing(polygon.LineStrings[0]);
                if (polygon.LineStrings.Count > 1) {
                    var interiors = new List<AbstractRingPropertyType>();
                    foreach (var lineString in polygon.LineStrings.Take(1)) {
                        var interior = new AbstractRingPropertyType();
						if (!lineString.IsClosed()) {
							lineString.Positions.Add(lineString.Positions[0]);
						}
                        exterior.Item = ToGmlLinearRing(lineString);
                        interiors.Add(interior);
                    }
                    gmlPolygon.Items1 = interiors.ToArray();
                    gmlPolygon.Items1ElementName = interiors.Select(int1 => Items1ChoiceType3.interior).ToArray();
                }
            }

            return gmlPolygon;
        }

        public static MultiSurfaceType ToGmlMultiSurface(this MultiPolygon multiPolygon) {            
            var gmlMultiSurface = new MultiSurfaceType();
            gmlMultiSurface.surfaceMembers = multiPolygon.Polygons.Select(p => p.ToGmlPolygon()).ToArray();

            return gmlMultiSurface;
        }

        public static GeometryObject ToGeometry(this AbstractGeometryType gmlObject) {

            if (gmlObject == null) {
                throw new ArgumentNullException("gmlObject");
            }

            if (gmlObject is MultiPolygonType) {
                return ((MultiPolygonType)gmlObject).ToGeometry();
            }

            if (gmlObject is MultiLineStringType) {
                return ((MultiLineStringType)gmlObject).ToGeometry();
            }

            if (gmlObject is MultiCurveType) {
                return ((MultiCurveType)gmlObject).ToGeometry();
            }

            if (gmlObject is MultiSurfaceType) {
                return ((MultiSurfaceType)gmlObject).ToGeometry();
            }

            if (gmlObject is PolygonType)
            {
                return ((PolygonType)gmlObject).ToGeometry();
            }

            if (gmlObject is PointType)
            {
                return ((PointType)gmlObject).ToGeometry();
            }

            if (gmlObject is LineStringType)
            {
                return ((LineStringType)gmlObject).ToGeometry();
            }

            if (gmlObject is LinearRingType)
            {
                return ((LinearRingType)gmlObject).ToGeometry();
            }

            if (gmlObject is MultiPointType)
            {
                return ((MultiPointType)gmlObject).ToGeometry();
            }

            throw new NotImplementedException();

        }

        public static MultiPolygon ToGeometry(this MultiSurfaceType gmlMultiSurface) {
            var polygons = new List<Polygon>();

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

                foreach (var member in gmlMultiSurface.surfaceMembers) {

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
            var linestrings = new List<LineString>();

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

                foreach (var member in gmlMultiCurve.curveMembers) {
                    if (member is LineStringType) {
                        linestrings.Add(((LineStringType)member).ToGeometry());
                        continue;
                    }

                    throw new NotImplementedException();
                }
            }

            return new MultiLineString(linestrings);
        }

        public static MultiPolygon ToGeometry(this MultiPolygonType gmlMultiPolygon) {
            var polygons = new List<Polygon>();

            if (gmlMultiPolygon.polygonMember != null) {

                foreach (var member in gmlMultiPolygon.polygonMember) {
                    polygons.Add(member.Polygon.ToGeometry());

                }
            }

            return new MultiPolygon(polygons);
        }

        public static MultiPoint ToGeometry(this MultiPointType gmlMultipoint)
        {
            var points = new List<IPosition>();

            if (gmlMultipoint.pointMember != null)
            {

                foreach (var member in gmlMultipoint.pointMember)
                {

                    points.Add(member.Point.ToGeometry().Position);

                }
            }

            if (gmlMultipoint.pointMembers != null)
            {

                foreach (var member in gmlMultipoint.pointMembers)
                {

                    points.Add(member.ToGeometry().Position);
                }
            }

            return new MultiPoint(points);
        }

        public static Polygon ToGeometry(this PolygonType gmlPolygon) {
            var polygon = new List<LineString>();
            LineString ls = null;

            if (gmlPolygon.Item != null) {

                var arpt = gmlPolygon.Item;


                if (arpt.Item is LinearRingType) {
                    ls = ((LinearRingType)arpt.Item).ToGeometry();

                    if (ls.Positions.Count < 4 || !ls.IsClosed())
                        throw new InvalidFormatException("invalid GML representation: polygon outer is not a closed ring of minimum 4 positions");
                }
            }

            if (ls == null)
                throw new InvalidFormatException("invalid GML representation: polygon outer is empty");

            polygon.Add(ls);


            if (gmlPolygon.Items1 != null) {
                foreach (var arpt in gmlPolygon.Items1) {

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

        public static MultiLineString ToGeometry(this MultiLineStringType gmlLineString) {
            var linestrings = new List<LineString>();

            if (gmlLineString.lineStringMember != null) {

                foreach (var member in gmlLineString.lineStringMember) {
                    linestrings.Add(member.LineString.ToGeometry());

                }
            }

            return new MultiLineString(linestrings);
        }

        public static LineString ToGeometry(this LinearRingType linearRing) {
            List<IPosition> positions;

            var posType = linearRing.Items1ElementName.First().GetType();

            positions = FromGMLData(linearRing.Items1, Array.ConvertAll(linearRing.Items1ElementName, i => i.ToString()));

            var linestring = new LineString(positions);

            if (linestring.Positions.Count < 4 || !linestring.IsClosed())
                throw new InvalidFormatException("invalid GML representation: linearring is not a closed ring of minimum 4 positions");

            return linestring;
        }

        public static LineString ToGeometry(this LineStringType lineString) {
            if (lineString.Items1 == null)
                return null;

            var points = FromGMLData(lineString.Items1, Array.ConvertAll(lineString.Items1ElementName, i => i.ToString()));

            if (points.Count < 2)
                throw new InvalidFormatException("invalid GML representation: LineString type must have at least 2 positions");

            return new LineString(points);
        }

        public static IPosition ToGeometry(this DirectPositionType pos) {
            IPosition position;

            int dim;

            var coord = pos.Text.Trim().Split(' ');
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
            var positions = new List<IPosition>();
            int dim;

            var coord = pos.Text.Trim().Split(' ');

            if (string.IsNullOrEmpty(pos.srsDimension))
                dim = 2; /* We assume that we are in 2D */
            else {
                dim = int.Parse(pos.srsDimension);
                if (dim < 2 || dim > 3)
                    throw new InvalidFormatException("invalid GML representation: gml:pos dimension equals " + dim);
            }

            for (var i = 0; i < coord.Length; i += dim) {
                if (dim == 2)
                    positions.Add(new GeographicPosition(coord[i + 0], coord[i + 1], null));
                if (dim == 3)
                    positions.Add(new GeographicPosition(coord[i + 0], coord[i + 1], coord[i + 2]));
            }
            return positions;
        }

        public static List<IPosition> ToGeometry(this CoordinatesType coordinates) {

            var positions = new List<IPosition>();
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
            gmlcoord = coordinates.Value.Trim();
            if (string.IsNullOrEmpty(gmlcoord))
                throw new InvalidFormatException("invalid GML representation: gml:coordinates is empty");

            var coordinates1 = gmlcoord.Split(ts);

            foreach (var coord in coordinates1) {

                var pos = coord.Split(cs);

                var x = double.Parse(pos[1]);
                var y = double.Parse(pos[0]);
                double? z = null;
                if (pos.Length > 2)
                    z = double.Parse(pos[2]);

                positions.Add(new GeographicPosition(y, x, z));

            }
            return positions;

        }

        public static IPosition ToGeometry(this CoordType coord) {

            /* Check dimension consistancy */
            if (coord.X == null || coord.Y == null)
                throw new InvalidFormatException("invalid GML representation: gml:coord missing X or Y");

            var geopos = new GeographicPosition(Convert.ToDouble(coord.X), Convert.ToDouble(coord.Y), Convert.ToDouble(coord.Z)); 
            return geopos;
        }

        public static Point ToGeometry(this PointType point) {

            if (point.Item is DirectPositionType)
                return new Point(((DirectPositionType)point.Item).ToGeometry());
            if (point.Item is CoordinatesType)
                return new Point(((CoordinatesType)point.Item).ToGeometry().First());
            if (point.Item is CoordType)
                return new Point(((CoordType)point.Item).ToGeometry());

            throw new InvalidFormatException("invalid GML representation: gml:point is empty");
        }

        private static List<IPosition> FromGMLData(object[] items, string[] itemsType) {

            var positions = new List<IPosition>();

            for (var i = 0; i < items.Length; i++) {

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
                    case "coord":
                        positions.Add(((CoordType)items[i]).ToGeometry());
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

