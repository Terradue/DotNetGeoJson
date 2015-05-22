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
using System.Globalization;
using System.Linq;
using Terradue.GeoJson.Feature;

namespace Terradue.GeoJson.Geometry
{
  public static class WktFeatureExtensions
  {
    private static readonly IFormatProvider ci = CultureInfo.InvariantCulture;

    public static string ToWkt(this Feature.Feature feature)
    {
      if (feature is PointFeature)
      {
        return PointFeatureToWkt((PointFeature) feature);
      }

      if ((feature is Feature.Feature && feature.Geometry is Point))
      {
        return PointFeatureToWkt(new PointFeature((Point) feature.Geometry));
      }

      if (feature is MultiPointFeature)
      {
        return MultiPointFeatureToWkt((MultiPointFeature) feature);
      }

      if ((feature is Feature.Feature && feature.Geometry is MultiPoint))
      {
        return MultiPointFeatureToWkt(new MultiPointFeature((MultiPoint) feature.Geometry));
      }

      if (feature is LineStringFeature)
      {
        return LineStringFeatureToWkt((LineStringFeature) feature);
      }

      if ((feature is Feature.Feature && feature.Geometry is LineString))
      {
        return LineStringFeatureToWkt(new LineStringFeature((LineString) feature.Geometry));
      }

      if (feature is PolygonFeature)
      {
        return PolygonFeatureToWkt((PolygonFeature) feature);
      }

      if ((feature is Feature.Feature && feature.Geometry is Polygon))
      {
        return PolygonFeatureToWkt(new PolygonFeature((Polygon) feature.Geometry));
      }

      if (feature is MultiPolygonFeature)
      {
        return MultiPolygonFeatureToWkt((MultiPolygonFeature) feature);
      }

      if ((feature is Feature.Feature && feature.Geometry is MultiPolygon))
      {
        return MultiPolygonFeatureToWkt(new MultiPolygonFeature((MultiPolygon) feature.Geometry));
      }

      return null;
    }

    public static string ToWkt(this GeometryObject geometry)
    {
      if (geometry is Point)
      {
        var point = GeometryToWktString((Point) geometry);

        return string.Format("POINT({0})", point);
      }

      if (geometry is MultiPoint)
      {
        var point = GeometryToWktString((MultiPoint) geometry);

        return string.Format("MULTIPOINT({0})", point);
      }

      if (geometry is LineString)
      {
        var linestring = GeometryToWktString((LineString) geometry);

        return string.Format("LINESTRING({0})", linestring);
      }

      if (geometry is Polygon)
      {
        var polygon = GeometryToWktString((Polygon) geometry);

        return string.Format("POLYGON({0})", polygon);
      }

      if (geometry is MultiPolygon)
      {
        var multiPolygon = GeometryToWktString((MultiPolygon) geometry);

        return string.Format("MULTIPOLYGON({0})", multiPolygon);
      }

      return null;
    }

    private static string PointFeatureToWkt(PointFeature pointFeature)
    {
      var point = GeometryToWktString(pointFeature.Geometry);

      return string.Format("POINT({0})", point);
    }

    private static string MultiPointFeatureToWkt(MultiPointFeature multiPointFeature)
    {
      var point = GeometryToWktString(multiPointFeature.Geometry);

      return string.Format("MULTIPOINT({0})", point);
    }

    private static string LineStringFeatureToWkt(LineStringFeature lineStringFeature)
    {
      var linestring = GeometryToWktString(lineStringFeature.Geometry);

      return string.Format("LINESTRING({0})", linestring);
    }

    private static string PolygonFeatureToWkt(PolygonFeature polygonFeature)
    {
      var polygon = GeometryToWktString(polygonFeature.Geometry);

      return string.Format("POLYGON({0})", polygon);
    }

    private static string MultiPolygonFeatureToWkt(MultiPolygonFeature multiPolygonFeature)
    {
      var multiPolygon = GeometryToWktString(multiPolygonFeature.Geometry);

      return string.Format("MULTIPOLYGON({0})", multiPolygon);
    }

    private static string GeometryToWktString(Point point)
    {
      return GeometryToWktString(point.Position);
    }

    private static string GeometryToWktString(MultiPoint multiPoint)
    {
      return string.Join(",", multiPoint.Points.Select(GeometryToWktString));
    }

    private static string GeometryToWktString(IPosition position)
    {
      if (position is GeographicPosition)
        return string.Format(ci, "{0} {1}", ((GeographicPosition) position).Longitude,
          ((GeographicPosition) position).Latitude);

      return "";
    }

    private static string GeometryToWktString(LineString lineString)
    {
      return string.Join(",", lineString.Positions.Select(GeometryToWktString));
    }

    private static string GeometryToWktString(Polygon polygon)
    {
      return string.Format("({0})", string.Join(",", polygon.LineStrings.Select(GeometryToWktString)));
    }

    private static string GeometryToWktString(MultiPolygon multiPolygon)
    {
      return string.Format("({0})", string.Join(",", multiPolygon.Polygons.Select(GeometryToWktString)));
    }
  }
}