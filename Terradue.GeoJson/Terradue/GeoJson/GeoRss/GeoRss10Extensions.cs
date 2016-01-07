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
using Terradue.GeoJson.Gml311;

namespace Terradue.GeoJson.GeoRss10 {
    
    public static class GeoRss10Extensions {
        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss10.GeoRss10Where where) {
           
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

        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss10.GeoRss10Point georssPoint) {

            if ( georssPoint.Item == null ) return null;

            return new Point(new DirectPositionType(){ Text = georssPoint.Item }.ToGeometry());

        }

        public static GeometryObject ToGeometry(this Terradue.GeoJson.GeoRss10.GeoRss10Polygon georssPolygon) {

            if ( georssPolygon.Item == null ) return null;

            Polygon polygon = new Polygon();

            polygon.LineStrings = new System.Collections.Generic.List<LineString>();

            LineString ls = new LineString(new DirectPositionListType(){ Text = georssPolygon.Item }.ToGeometry());

            if (ls.Positions.Count < 4 || !ls.IsClosed())
                throw new InvalidFormatException("invalid GML representation: linearring is not a closed ring of minimum 4 positions");

            polygon.LineStrings.Add(ls);

            return polygon;

        }
    }
}

