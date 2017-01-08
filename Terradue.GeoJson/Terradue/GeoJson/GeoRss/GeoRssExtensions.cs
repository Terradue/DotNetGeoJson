//
//  GeoRss10Extensions.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2015 Terradue
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
using Terradue.GeoJson.Geometry;
using Terradue.ServiceModel.Ogc.Gml311;
using System.Collections.Generic;
using Terradue.GeoJson.Gml311;
using System.Xml;
using System.IO;
using System.Linq;

namespace Terradue.GeoJson.GeoRss {
    
    public static class GeoRssExtensions {

        public static XmlReader CreateReader(this IGeoRSS georss){
            var stream = new MemoryStream();
            var writer = XmlWriter.Create(stream);
            GeoRssHelper.Serialize(writer, georss);
            stream.Seek(0, SeekOrigin.Begin);
            return XmlReader.Create(stream);
        }

        public static GeometryObject ToGeometry(this IGeoRSS georss) {

            if (georss is GeoRssPoint) {
                return ((GeoRssPoint)georss).ToGeometry();
            }

            if (georss is GeoRssLine) {
                return ((GeoRssLine)georss).ToGeometry();
            }

            if (georss is GeoRssPolygon) {
                return ((GeoRssPolygon)georss).ToGeometry();
            }

            if (georss is GeoRssBox) {
                return ((GeoRssBox)georss).ToGeometry();
            }

            if (georss is GeoRssWhere) {
                return ((GeoRssWhere)georss).ToGeometry();
            }

            return null;

        }

        public static GeometryObject ToGeometry(this GeoRssWhere where) {
           
			if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is EnvelopeType) {
                throw new NotImplementedException();
            }

			if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is CircleByCenterPointType) {
                throw new NotImplementedException();
            }

			if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is LineStringType) {
                return ((LineStringType)where.Item[0]).ToGeometry();
            }

			if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is PointType) {
                return ((PointType)where.Item[0]).ToGeometry();
            }

			if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is PolygonType) {
                return ((PolygonType)where.Item[0]).ToGeometry();
            }

            if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is MultiPolygonType)
            {
                return ((MultiPolygonType)where.Item[0]).ToGeometry();
            }

            if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is MultiCurveType) {
                return ((MultiCurveType)where.Item[0]).ToGeometry();
            }

            if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is MultiPolygonType)
            {
                return ((MultiCurveType)where.Item[0]).ToGeometry();
            }

            if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is MultiSurfaceType)
            {
                return ((MultiSurfaceType)where.Item[0]).ToGeometry();
            }

            if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is MultiPointType)
            {
                return ((MultiPointType)where.Item[0]).ToGeometry();
            }

            if (where.Item != null && where.Item.Count() > 0 && where.Item[0] is MultiLineStringType)
            {
                return ((MultiLineStringType)where.Item[0]).ToGeometry();
            }

            return null;

        }

        public static GeometryObject ToGeometry(this GeoRssPoint georssPoint) {

            if (georssPoint.Item == null)
                return null;

            return new Point(new DirectPositionType(){ Text = georssPoint.Item }.ToGeometry());

        }

        public static GeometryObject ToGeometry(this GeoRssLine georssLine) {

            if (georssLine.Item == null)
                return null;

            return new LineString(new DirectPositionListType(){ Text = georssLine.Item }.ToGeometry());

        }

        public static GeometryObject ToGeometry(this GeoRssPolygon georssPolygon) {

            if (georssPolygon.Item == null)
                return null;

            var polygon = new Polygon();

            polygon.LineStrings = new List<LineString>();

            var ls = new LineString(new DirectPositionListType(){ Text = georssPolygon.Item }.ToGeometry());

            if (ls.Positions.Count < 4 || !ls.IsClosed())
                throw new InvalidFormatException("invalid GML representation: linearring is not a closed ring of minimum 4 positions");

            polygon.LineStrings.Add(ls);

            return polygon;

        }

        public static GeometryObject ToGeometry(this GeoRssBox georssBox) {

            if (georssBox.Item == null)
                return null;

            var position = new List<IPosition>();
            var polygon = new List<LineString>();
            string georssbox;
            
            georssbox = georssBox.Item.Trim();
            
            var pos = georssbox.Split(' ');
            
            if (pos.Length != 4)
                throw new InvalidFormatException("invalid GeoRSS representation: georss:box members are not 4 :" + georssbox);
            
            position.Add(new GeographicPosition(pos[0], pos[1]));
            position.Add(new GeographicPosition(pos[0], pos[3]));
            position.Add(new GeographicPosition(pos[2], pos[3]));
            position.Add(new GeographicPosition(pos[2], pos[1]));
            position.Add(new GeographicPosition(pos[0], pos[1]));
            
            polygon.Add(new LineString(position));
            return new Polygon(polygon);

        }

        public static IGeoRSS ToGeoRss(this GeometryObject geom) {

            if (geom is Point)
                return ((Point)geom).ToGeoRssPoint();

            if (geom is LineString)
                return ((LineString)geom).ToGeoRssLine();

            if (geom is Polygon && ((Polygon)geom).LineStrings.Count == 1)
                return ((Polygon)geom).ToGeoRssPolygon();

            if (geom is Polygon && ((Polygon)geom).LineStrings.Count > 1)
                return ((Polygon)geom).ToGeoRssWhere();

            if (geom is MultiPolygon && ((MultiPolygon)geom).Polygons.Count == 1)
                return ((MultiPolygon)geom).Polygons.First().ToGeoRss();

            if (geom is MultiPolygon && ((MultiPolygon)geom).Polygons.Count > 1)
                return ((MultiPolygon)geom).ToGeoRssWhere();

            if (geom is MultiPoint && ((MultiPoint)geom).Points.Count == 1)
                return ((MultiPoint)geom).Points.First().ToGeoRss();

            if (geom is MultiPoint)
                return ((MultiPoint)geom).ToGeoRssWhere();

            if (geom is MultiLineString && ((MultiLineString)geom).LineStrings.Count == 1)
                return ((MultiLineString)geom).LineStrings.First().ToGeoRss();
            
            if (geom is MultiLineString)
                return ((MultiLineString)geom).ToGeoRssWhere();

            throw new NotImplementedException();
        }

        public static GeoRssWhere ToGeoRssWhere(this GeometryObject geom) {

            if (geom is Point)
                return ((Point)geom).ToGeoRssWhere();

            if (geom is LineString)
                return ((LineString)geom).ToGeoRssWhere();

            if (geom is Polygon)
                return ((Polygon)geom).ToGeoRssWhere();

            if (geom is MultiPolygon)
                return ((MultiPolygon)geom).ToGeoRssWhere();

            if (geom is MultiPoint)
                return ((MultiPoint)geom).ToGeoRssWhere();

            if (geom is MultiLineString)
                return ((MultiLineString)geom).ToGeoRssWhere();


            throw new NotImplementedException();
        }

        public static GeoRssPoint ToGeoRssPoint(this Point point) {

            return new GeoRssPoint(){ Item = point.Position.ToGmlPos().Text };
        }

        public static GeoRssLine ToGeoRssLine(this LineString lineString) {

            return new GeoRssLine(){ Item = lineString.Positions.ToArray().ToGmlPosList().Text };
        }

        public static GeoRssPolygon ToGeoRssPolygon(this Polygon polygon) {

            return new GeoRssPolygon(){ Item = polygon.LineStrings[0].Positions.ToArray().ToGmlPosList().Text };
        }

        public static GeoRssWhere ToGeoRssWhere(this Polygon polygon) {

			return new GeoRssWhere(){ Item = new PolygonType[] { polygon.ToGmlPolygon() } };
        }

        public static GeoRssWhere ToGeoRssWhere(this LineString line) {

			return new GeoRssWhere() { Item = new LineStringType[] { line.ToGmlLineString() } };
        }

        public static GeoRssWhere ToGeoRssWhere(this Point point) {

			return new GeoRssWhere(){ Item = new PointType[] { point.ToGmlPoint() } };
        }

        public static GeoRssWhere ToGeoRssWhere(this MultiPolygon mpolygon) {

            if (mpolygon.Polygons.Count() > 1)
            {
                return new GeoRssWhere() { Item = new MultiPolygonType[] { mpolygon.ToGmlMultiPolygon() }, Type = "multipolygon" };
            }
            else {
                return new GeoRssWhere() { Item = new PolygonType[] { mpolygon.Polygons.First().ToGmlPolygon() } };
            }
        }

        public static GeoRssWhere ToGeoRssWhere(this MultiPoint mpoint) {

            if (mpoint.Points.Count() > 1)
            {

                return new GeoRssWhere() { Item = new MultiPointType[] { mpoint.ToGmlMultiPoint() }, Type = "multipoint" };
            }
            else {
                return new GeoRssWhere() { Item = new PointType[] { mpoint.Points.First().ToGmlPoint() } };
            }

        }

        public static GeoRssWhere ToGeoRssWhere(this MultiLineString mlinestring)
        {

            if (mlinestring.LineStrings.Count() > 1)
            {

                return new GeoRssWhere() { Item = new MultiLineStringType[] { mlinestring.ToGmlMultiLineString() }, Type = "multilinestring" };
            }
            else {
                return new GeoRssWhere() { Item = new LineStringType[] { mlinestring.LineStrings.First().ToGmlLineString() } };
            }

        }
    }
}

