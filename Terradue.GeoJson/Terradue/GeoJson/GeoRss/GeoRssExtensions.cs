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

namespace Terradue.GeoJson.GeoRss {
    
    public static class GeoRssExtensions {
        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss.GeoRssWhere where) {
           
            if (where.Item is EnvelopeType) {
                throw new NotImplementedException();
            }

            if (where.Item is CircleByCenterPointType) {
                throw new NotImplementedException();
            }

            if (where.Item is LineStringType) {
                return ((LineStringType)where.Item).ToGeometry();
            }

            if (where.Item is PointType) {
                return ((PointType)where.Item).ToGeometry();
            }

            if (where.Item is PolygonType) {
                return ((PolygonType)where.Item).ToGeometry();
            }

            return null;

        }

        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss.GeoRssPoint georssPoint) {

            if (georssPoint.Item == null)
                return null;

            return new Point(new DirectPositionType(){ Text = georssPoint.Item }.ToGeometry());

        }

        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss.GeoRssLine georssLine) {

            if (georssLine.Item == null)
                return null;

            return new LineString(new DirectPositionListType(){ Text = georssLine.Item }.ToGeometry());

        }

        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss.GeoRssPolygon georssPolygon) {

            if (georssPolygon.Item == null)
                return null;

            Polygon polygon = new Polygon();

            polygon.LineStrings = new System.Collections.Generic.List<LineString>();

            LineString ls = new LineString(new DirectPositionListType(){ Text = georssPolygon.Item }.ToGeometry());

            if (ls.Positions.Count < 4 || !ls.IsClosed())
                throw new InvalidFormatException("invalid GML representation: linearring is not a closed ring of minimum 4 positions");

            polygon.LineStrings.Add(ls);

            return polygon;

        }

        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss.GeoRssBox georssBox) {

            if (georssBox.Item == null)
                return null;

            List<IPosition> position = new List<IPosition>();
            List<LineString> polygon = new List<LineString>();
            string georssbox;
            
            georssbox = georssBox.Item.Trim();
            
            string[] pos = georssbox.Split(' ');
            
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

        public static Terradue.GeoJson.GeoRss.IGeoRSS ToGeoRss(this GeometryObject geom) {

            if (geom is Point)
                return ((Point)geom).ToGeoRssPoint();

            if (geom is LineString)
                return ((LineString)geom).ToGeoRssLine();

            if (geom is Polygon && ((Polygon)geom).LineStrings.Count == 1)
                return ((Polygon)geom).ToGeoRssPolygon();

            if (geom is Polygon && ((Polygon)geom).LineStrings.Count > 1)
                return ((Polygon)geom).ToGeoRssWhere();

            if (geom is MultiPolygon)
                return ((MultiPolygon)geom).ToGeoRssWhere();

            if (geom is MultiPoint)
                return ((MultiPoint)geom).ToGeoRssWhere();


            throw new NotImplementedException();
        }

        public static Terradue.GeoJson.GeoRss.GeoRssWhere ToGeoRssWhere(this GeometryObject geom) {

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


            throw new NotImplementedException();
        }

        public static Terradue.GeoJson.GeoRss.GeoRssPoint ToGeoRssPoint(this Point point) {

            return new Terradue.GeoJson.GeoRss.GeoRssPoint(){ Item = point.Position.ToGmlPos().Text };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssLine ToGeoRssLine(this LineString lineString) {

            return new Terradue.GeoJson.GeoRss.GeoRssLine(){ Item = lineString.Positions.ToArray().ToGmlPosList().Text };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssPolygon ToGeoRssPolygon(this Polygon polygon) {

            return new Terradue.GeoJson.GeoRss.GeoRssPolygon(){ Item = polygon.LineStrings[0].Positions.ToArray().ToGmlPosList().Text };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssWhere ToGeoRssWhere(this Polygon polygon) {

            return new Terradue.GeoJson.GeoRss.GeoRssWhere(){ Item = polygon.ToGmlPolygon() };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssWhere ToGeoRssWhere(this LineString line) {

            return new Terradue.GeoJson.GeoRss.GeoRssWhere(){ Item = line.ToGmlLineString() };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssWhere ToGeoRssWhere(this Point point) {

            return new Terradue.GeoJson.GeoRss.GeoRssWhere(){ Item = point.ToGmlPoint() };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssWhere ToGeoRssWhere(this MultiPolygon mpolygon) {

            return new Terradue.GeoJson.GeoRss.GeoRssWhere(){ Item = mpolygon.ToGmlMultiSurface() };
        }

        public static Terradue.GeoJson.GeoRss.GeoRssWhere ToGeoRssWhere(this MultiPoint mpoint) {

            return new Terradue.GeoJson.GeoRss.GeoRssWhere(){ Item = mpoint.ToGmlMultiPoint() };
        }
    }
}

