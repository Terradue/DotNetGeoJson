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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Gml;

namespace Terradue.GeoJson.Geometry
{
  public static class GmlFeatureExtensions
  {
    private static readonly IFormatProvider ci = CultureInfo.InvariantCulture;
    private static readonly XmlSerializer GmlPointSerializer = new XmlSerializer(typeof (PointType));

    private static readonly XmlSerializer GmlMultiPointSerializer =
      new XmlSerializer(typeof (MultiPointType));

    private static readonly XmlSerializer GmlLineStringSerializer =
      new XmlSerializer(typeof (LineStringType));

    private static readonly XmlSerializer GmlMultiLineStringSerializer =
      new XmlSerializer(typeof (MultiCurveType));

    private static readonly XmlSerializer GmlPolygonSerializer =
      new XmlSerializer(typeof (PolygonType));

    private static readonly XmlSerializer GmlMultiSurfaceSerializer =
      new XmlSerializer(typeof (MultiSurfaceType));

    public static XmlElement ToMultiCurveGml(this GeometryObject geometry)
    {
      var xdoc = new XmlDocument();

      using (var writer = xdoc.CreateNavigator().AppendChild())
      {
        if (geometry is LineString)
        {
          var lineStrings = new List<LineString>();
          lineStrings.Add((LineString) geometry);
          var multiLineString = new MultiLineString(lineStrings);

          GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml(multiLineString));
        }
        else if (geometry is MultiLineString)
        {
          GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiLineString) geometry));
        }
        else
          return null;
      }

      return xdoc.DocumentElement;
    }

    public static XmlElement ToMultiSurfaceGml(this GeometryObject geometry)
    {
      var xdoc = new XmlDocument();

      using (var writer = xdoc.CreateNavigator().AppendChild())
      {
        if (geometry is Polygon)
        {
          var polygons = new List<Polygon>();
          polygons.Add((Polygon) geometry);
          var multiPolygon = new MultiPolygon(polygons);

          GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml(multiPolygon));
        }
        else if (geometry is MultiPolygon)
        {
          GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiPolygon) geometry));
        }
        else
          return null;
      }

      return xdoc.DocumentElement;
    }

    public static MultiSurfaceType ToMultiSurface(
      this GeometryObject geometry)
    {
      if (geometry is Polygon)
      {
        var polygons = new List<Polygon>();
        polygons.Add((Polygon) geometry);
        var multiPolygon = new MultiPolygon(polygons);

        return GeometryToGml(multiPolygon);
      }
      if (geometry is MultiPolygon)
      {
        return GeometryToGml((MultiPolygon) geometry);
      }
      return null;
    }

    public static MultiCurveType ToMultiCurve(
      this GeometryObject geometry)
    {
      if (geometry is LineString)
      {
        var lineStrings = new List<LineString>();
        lineStrings.Add((LineString) geometry);
        var multiLineString = new MultiLineString(lineStrings);

        return GeometryToGml(multiLineString);
      }
      if (geometry is MultiLineString)
      {
        return GeometryToGml((MultiLineString) geometry);
      }
      return null;
    }

    public static XmlElement ToGml(this GeometryObject geometry)
    {
      var xdoc = new XmlDocument();

      using (var writer = xdoc.CreateNavigator().AppendChild())
      {
        if (geometry is Point)
        {
          GmlPointSerializer.Serialize(writer, GeometryToGml((Point) geometry));
        }

        if (geometry is MultiPoint)
        {
          GmlMultiPointSerializer.Serialize(writer, GeometryToGml((MultiPoint) geometry));
        }

        if (geometry is LineString)
        {
          GmlLineStringSerializer.Serialize(writer, GeometryToGml((LineString) geometry));
        }

        if (geometry is MultiLineString)
        {
          GmlMultiLineStringSerializer.Serialize(writer, GeometryToGml((MultiLineString) geometry));
        }

        if (geometry is Polygon)
        {
          GmlPolygonSerializer.Serialize(writer, GeometryToGml((Polygon) geometry));
        }

        if (geometry is MultiPolygon)
        {
          GmlMultiSurfaceSerializer.Serialize(writer, GeometryToGml((MultiPolygon) geometry));
        }
      }

      return xdoc.DocumentElement;
    }

    public static PointType PointFeatureToGml(PointFeature pointFeature)
    {
      return GeometryToGml(pointFeature.Geometry);
    }

    public static MultiPointType MultiPointFeatureToGml(MultiPointFeature multiPointFeature)
    {
      return GeometryToGml(multiPointFeature.Geometry);
    }

    public static LineStringType LineStringFeatureToGml(LineStringFeature lineStringFeature)
    {
      return GeometryToGml(lineStringFeature.Geometry);
    }

    public static PolygonType PolygonFeatureToGml(PolygonFeature polygonFeature)
    {
      return GeometryToGml(polygonFeature.Geometry);
    }

    public static MultiSurfaceType MultiPolygonFeatureToGml(MultiPolygonFeature multiPolygonFeature)
    {
      return GeometryToGml(multiPolygonFeature.Geometry);
    }

    public static PointType GeometryToGml(Point point)
    {
      var gmlPoint = new PointType();
      var gmlPos = GeometryToGml(point.Position);
      gmlPoint.srsDimension = gmlPos.srsDimension;
      gmlPoint.Item = gmlPos;
      return gmlPoint;
    }

    public static MultiPointType GeometryToGml(MultiPoint multiPoint)
    {
      var gmlMultiPoint = new MultiPointType();
      var gmlPointMembers = new List<PointPropertyType>();
      foreach (var point in multiPoint.Points)
      {
        var gmlPointMember = new PointPropertyType();
        gmlPointMember.Point = GeometryToGml(point);
        gmlPointMembers.Add(gmlPointMember);
      }
      gmlMultiPoint.pointMember = gmlPointMembers.ToArray();
      return gmlMultiPoint;
    }

    public static DirectPositionType GeometryToGml(IPosition position)
    {
      if (position is GeographicPosition)
      {
        var gmlPos = new DirectPositionType();
        gmlPos.srsDimension = ((GeographicPosition) position).Altitude == null ? "2" : "3";
        var p = (GeographicPosition) position;
        gmlPos.Text = string.Format("{0} {1}{2}", p.Latitude, p.Longitude, p.Altitude == null ? "" : " " + p.Altitude);
        return gmlPos;
      }
      return null;
    }

    public static DirectPositionListType GeometryToGml(IPosition[] positions)
    {
      if (positions.Length > 0 && positions[0] is GeographicPosition)
      {
        var gmlPosList = new DirectPositionListType();
        gmlPosList.count = positions.Length.ToString();
        gmlPosList.Text = string.Join(" ",
          positions.Cast<GeographicPosition>()
            .Select<GeographicPosition, string>(
              p => string.Format("{0} {1}{2}", p.Latitude, p.Longitude, p.Altitude == null ? "" : " " + p.Altitude)));
        gmlPosList.srsDimension = ((GeographicPosition) positions[0]).Altitude == null ? "2" : "3";
        return gmlPosList;
      }
      return null;
    }

    public static LineStringType GeometryToGml(LineString lineString)
    {
      var gmlLineString = new LineStringType();
      gmlLineString.ItemsElementName = new ItemsChoiceType[1];
      gmlLineString.ItemsElementName[0] = ItemsChoiceType.posList;
      gmlLineString.Items = new object[1];
      gmlLineString.Items[0] = GeometryToGml(lineString.Positions.ToArray());
      return gmlLineString;
    }

    public static MultiCurveType GeometryToGml(MultiLineString multiLineString)
    {
      var gmlMultiLineString = new MultiCurveType {curveMembers = new CurveArrayPropertyType()};
      var gmlLineStrings = new List<LineStringType>();
      foreach (var lineString in multiLineString.LineStrings)
      {
        gmlLineStrings.Add(GeometryToGml(lineString));
      }
      gmlMultiLineString.curveMembers.Items = gmlLineStrings.ToArray();
      return gmlMultiLineString;
    }

    public static PolygonType GeometryToGml(Polygon polygon)
    {
      var gmlPolygon = new PolygonType();
      if (polygon.LineStrings.Count > 0)
      {
        var exterior = new AbstractRingPropertyType();
        gmlPolygon.exterior = exterior;
        var linearRing = new LinearRingType();
        exterior.Item = linearRing;
        linearRing.ItemsElementName = new ItemsChoiceType6[1];
        linearRing.ItemsElementName[0] = ItemsChoiceType6.posList;
        linearRing.Items = new object[1];
        linearRing.Items[0] = GeometryToGml(polygon.LineStrings[0].Positions.ToArray());
        if (polygon.LineStrings.Count > 1)
        {
          var interiors = new List<AbstractRingPropertyType>();
          foreach (var lineString in polygon.LineStrings.Take(1))
          {
            var interior = new AbstractRingPropertyType();
            linearRing = new LinearRingType();
            exterior.Item = linearRing;
            linearRing = new LinearRingType {ItemsElementName = new ItemsChoiceType6[1]};
            linearRing.ItemsElementName[0] = ItemsChoiceType6.posList;
            linearRing.Items = new object[1];
            linearRing.Items[0] = GeometryToGml(lineString.Positions.ToArray());
            interiors.Add(interior);
          }
          gmlPolygon.interior = interiors.ToArray();
        }
      }

      return gmlPolygon;
    }

    public static MultiSurfaceType GeometryToGml(MultiPolygon multiPolygon)
    {
      var gmlMultiSurface = new MultiSurfaceType {surfaceMembers = new SurfaceArrayPropertyType()};
      var gmlPolygons = new List<PolygonType>();
      foreach (var polygon in multiPolygon.Polygons)
      {
        gmlPolygons.Add(GeometryToGml(polygon));
      }
      gmlMultiSurface.surfaceMembers.Items = gmlPolygons.ToArray();

      return gmlMultiSurface;
    }
  }
}