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
using System.Text.RegularExpressions;

namespace Terradue.GeoJson.Geometry
{
  public static class WktExtensions
  {
    private static readonly IFormatProvider ci = CultureInfo.InvariantCulture;

    public static string ToWkt(this Feature.Feature feature)
    {
      return ToWkt(feature.Geometry);
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

        return string.Format("MULTIPOINT{0}", point);
      }

      if (geometry is LineString)
      {
        var linestring = GeometryToWktString((LineString) geometry);

        return string.Format("LINESTRING{0}", linestring);
      }

      if (geometry is Polygon)
      {
        var polygon = GeometryToWktString((Polygon) geometry);

        return string.Format("POLYGON{0}", polygon);
      }

      if (geometry is MultiPolygon)
      {
        var multiPolygon = GeometryToWktString((MultiPolygon) geometry);

        return string.Format("MULTIPOLYGON{0}", multiPolygon);
      }

      if (geometry is MultiLineString)
      {
        var multiLineString = GeometryToWktString((MultiLineString) geometry);

        return string.Format("MULTILINESTRING{0}", multiLineString);
      }

      return null;
    }

    private static string GeometryToWktString(Point point)
    {
      return GeometryToWktString(point.Position);
    }

    private static string GeometryToWktString(MultiPoint multiPoint)
    {
      return string.Format("({0})", string.Join(",", multiPoint.Points.Select(GeometryToWktString)));
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
      return string.Format("({0})", string.Join(",", lineString.Positions.Select(GeometryToWktString)));
    }

    private static string GeometryToWktString(Polygon polygon)
    {
      return string.Format("({0})", string.Join(",", polygon.LineStrings.Select(GeometryToWktString)));
    }

    private static string GeometryToWktString(MultiPolygon multiPolygon)
    {
      return string.Format("({0})", string.Join(",", multiPolygon.Polygons.Select(GeometryToWktString)));
    }

    private static string GeometryToWktString(MultiLineString multiLineString)
    {
      return string.Format("({0})", string.Join(",", multiLineString.LineStrings.Select(GeometryToWktString)));
    }

    /// <summary>
    ///   Initialize a new IGemotry object from a standard WKT geometry
    /// </summary>
    /// <param name="wkt">The geometry in WKT to convert</param>
    public static GeometryObject WktToGeometry(string wkt)
    {
      wkt = wkt.Trim().Replace(", ", ",");
      var match = Regex.Match(wkt, @"([A-Z]+)\s*[(]\s*(\(*.+\)*)\s*[)]");
      if (match.Success)
        switch (match.Groups[1].Value)
        {
          case "MULTIPOLYGON":
            return MultiPolygonFromWKT(match.Groups[2].Value);
          case "POLYGON":
            return PolygonFromWKT(match.Groups[2].Value);
          case "MULTILINESTRING":
            return MultiLineStringFromWKT(match.Groups[2].Value);
          case "LINESTRING":
            return LineStringFromWKT(match.Groups[2].Value);
          case "MULTIPOINT":
            return MultiPointFromWKT(match.Groups[2].Value);
          case "POINT":
            return PointFromWKT(match.Groups[2].Value);
        }
      throw new NotImplementedException(wkt);
    }

    /// <summary>
    ///   MultiPolygon from WK.
    /// </summary>
    /// <returns>The MultiPolygon</returns>
    /// <param name="wkt">WKT.</param>
    public static MultiPolygon MultiPolygonFromWKT(string wkt)
    {
      var matches = Regex.Matches(wkt, @"([(](?:\ *[(]\ *(?:\ *(?:[0-9-.]+[ ]+[0-9-.]+)[, ]*\ *)*\ *[)][, ]*)*[)])");
      var polygons = new List<Polygon>(matches.Count);
      for (var i = 0; i < matches.Count; i++)
      {
        var polygon = PolygonFromWKT(matches[i].Groups[1].Value);
        polygons.Add(polygon);
      }

      return new MultiPolygon(polygons);
    }

    /// <summary>
    ///   Polygon from WK.
    /// </summary>
    /// <returns>The Polygon</returns>
    /// <param name="wkt">WKT.</param>
    public static Polygon PolygonFromWKT(string wkt)
    {
      var matches = Regex.Matches(wkt, @"(\ *[(]\ *(?:\ *(?:[0-9-.]+[ ]+[0-9-.]+)[, ]*\ *)*\ *[)])[, ]*");
      var linestrings = new List<LineString>(matches.Count);
      for (var i = 0; i < matches.Count; i++)
      {
        var linestring = LineStringFromWKT(matches[i].Groups[1].Value);
        linestrings.Add(linestring);
      }

      return new Polygon(linestrings);
    }

    /// <summary>
    ///   LineString from WKT.
    /// </summary>
    /// <returns>The LineString</returns>
    /// <param name="wkt">WKT.</param>
    public static LineString LineStringFromWKT(string wkt)
    {
      var terms = wkt.TrimStart('(').TrimEnd(')').Split(',');
      string[] values;
      var positions = new List<IPosition>(terms.Length);
      GeographicPosition prevgeopos = null;
      for (var i = 0; i < terms.Length; i++)
      {
        values = terms[i].Trim(' ').Split(' ');
        var z = values.Length > 2 ? values[2] : null;
        var geopos = new GeographicPosition(values[1], values[0], z);
        try
        {
          if ((prevgeopos != null) && geopos.Coordinates.SequenceEqual(prevgeopos.Coordinates))
            continue;
        }
        catch
        {
        }
        positions.Add(geopos);
        prevgeopos = geopos;
      }

      var test = new LineString(positions);
      return test;
    }

    /// <summary>
    ///   MultiLineString from WK.
    /// </summary>
    /// <returns>The MultiLineString</returns>
    /// <param name="wkt">WKT.</param>
    public static MultiLineString MultiLineStringFromWKT(string wkt)
    {
      var matches = Regex.Matches(wkt, @"(\ *[(]\ *(?:\ *(?:[0-9-.]+[ ]+[0-9-.]+)[, ]*\ *)*\ *[)])[, ]*");
      var linestrings = new List<LineString>(matches.Count);
      for (var i = 0; i < matches.Count; i++)
      {
        var linestring = LineStringFromWKT(matches[i].Groups[1].Value);
        linestrings.Add(linestring);
      }

      return new MultiLineString(linestrings);
    }

    /// <summary>
    ///   MultiPoint from WK.
    /// </summary>
    /// <returns>The MultiPoint</returns>
    /// <param name="wkt">WKT.</param>
    public static MultiPoint MultiPointFromWKT(string wkt)
    {
      var terms = wkt.TrimStart('(').TrimEnd(')').Trim(' ').Split(',');
      string[] values;
      var points = new List<IPosition>(terms.Length);
      foreach (var t in terms)
      {
        values = t.Split(' ');
        var z = values.Length > 2 ? values[2] : null;
        var geopos = new GeographicPosition(values[1], values[0], z);
        points.Add(geopos);
      }
      return new MultiPoint(points);
    }

    /// <summary>
    ///   Point from WK.
    /// </summary>
    /// <returns>The Point</returns>
    /// <param name="wkt">WKT.</param>
    public static Point PointFromWKT(string wkt)
    {
      var values = wkt.Trim(' ').Split(' ');
      var z = values.Length > 2 ? values[2] : null;
      var geopos = new GeographicPosition(values[1], values[0], z);
      return new Point(geopos);
    }
  }
}