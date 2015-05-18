//
//  GeographicPosition.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using System.Globalization;
using Terradue.GeoJson.Feature;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Geometry
{
  /// <summary>
  /// Static class to hold utilities methods
  /// </summary>
  public static class GeometryFactory
  {

    public static Feature.Feature GeoRSSToFeature(XmlElement element)
    {

      var properties = new Dictionary<string, object>();
      IGeometryObject geometry = null;

      if (element == null)
        return new NoGeometryFeature(properties);

      try
      {
        geometry = GeoRSSToGeometry(element);
      }
      catch (InvalidFormatException e)
      {
        properties.Add("Exception",
          String.Format("The GeoRSS object {0} has an invalid format: {1}", element.LocalName, e.Message));
        return new NoGeometryFeature(properties);
      }
      catch (Exception e)
      {
        properties.Add("Exception",
          String.Format("The GeoRSS object {0} conversion returned an error: {1}", element.LocalName, e.Message));
        return new NoGeometryFeature(properties);
      }

      if (geometry.GetType() == typeof (MultiPolygon))
      {
        geometry = SplitWorldExtent((MultiPolygon) geometry);
        return new MultiPolygonFeature((MultiPolygon) geometry, properties);
      }

      if (geometry.GetType() == typeof (Polygon))
      {
        geometry = SplitWorldExtent((Polygon) geometry);
        return new PolygonFeature((Polygon) geometry, properties);
      }

      if (geometry.GetType() == typeof (MultiPoint))
      {
        return new MultiPointFeature((MultiPoint) geometry, properties);
      }

      if (geometry.GetType() == typeof (MultiLineString))
      {
        return new MultiLineStringFeature((MultiLineString) geometry, properties);
      }

      properties.Add("Exception",
        String.Format("The GeoRSS object {0} is not implemented. Please report", element.LocalName));


      return new NoGeometryFeature(properties);
    }

    /// <summary>
    /// Gml Transformer to Feature.
    /// </summary>
    /// <returns>The Geometric Feature</returns>
    /// <param name="element">GML Xml Element</param>
    public static Feature.Feature GmlToFeature(XmlElement element)
    {

      var properties = new Dictionary<string, object>();
      IGeometryObject geometry = null;

      if (element == null)
        return new NoGeometryFeature(properties);

      try
      {
        geometry = GmlToGeometry(element);
      }
      catch (InvalidFormatException e)
      {
        properties.Add("Exception",
          String.Format("The GML object {0} has an invalid format: {1}", element.LocalName, e.Message));
        return new NoGeometryFeature(properties);
      }
      catch (Exception e)
      {
        properties.Add("Exception",
          String.Format("The GML object {0} conversion returned an error: {1}", element.LocalName, e.Message));
        return new NoGeometryFeature(properties);
      }

      if (geometry.GetType() == typeof (MultiPolygon))
      {
        geometry = SplitWorldExtent((MultiPolygon) geometry);
        return new MultiPolygonFeature((MultiPolygon) geometry, properties);
      }

      if (geometry.GetType() == typeof (Polygon))
      {
        geometry = SplitWorldExtent((Polygon) geometry);
        return new PolygonFeature((Polygon) geometry, properties);
      }

      if (geometry.GetType() == typeof (MultiPoint))
      {
        return new MultiPointFeature((MultiPoint) geometry, properties);
      }

      if (geometry.GetType() == typeof (MultiLineString))
      {
        return new MultiLineStringFeature((MultiLineString) geometry, properties);
      }

      properties.Add("Exception",
        String.Format("The GML object {0} is not implemented. Please report", element.LocalName));


      return new NoGeometryFeature(properties);
    }

    /// <summary>
    /// Create a Geometric Feature from a well known text
    /// </summary>
    /// <returns>The Geometric Feature</returns>
    /// <param name="wkt">String with the Well Known Text</param>
    public static Feature.Feature WktToFeature(string wkt)
    {

      var properties = new Dictionary<string, object>();

      if (string.IsNullOrEmpty(wkt))
        return new NoGeometryFeature(properties);

      IGeometryObject geometry = WktToGeometry(wkt);

      if (geometry.GetType() == typeof (MultiPolygon))
      {
        geometry = SplitWorldExtent((MultiPolygon) geometry);
        return new MultiPolygonFeature((MultiPolygon) geometry, new Dictionary<string, object>());
      }

      if (geometry.GetType() == typeof (Polygon))
      {
        geometry = SplitWorldExtent((Polygon) geometry);
        return new PolygonFeature((Polygon) geometry, new Dictionary<string, object>());
      }

      if (geometry.GetType() == typeof (MultiPoint))
      {
        return new MultiPointFeature((MultiPoint) geometry, new Dictionary<string, object>());
      }

      if (geometry.GetType() == typeof (Point))
      {
        return new PointFeature((Point) geometry, new Dictionary<string, object>());
      }

      if (geometry.GetType() == typeof (MultiLineString))
      {
        return new MultiLineStringFeature((MultiLineString) geometry, new Dictionary<string, object>());
      }

      if (geometry.GetType() == typeof (LineString))
      {
        //return new LineStringFeature ((LineString)geometry, new Dictionary<string,object> ());
        return null;
      }

      return new NoGeometryFeature(properties);

    }

    /// <summary>
    /// Initialize a new IGemotry object from a standard WKT geometry
    /// </summary>
    /// <param name="wkt">The geometry in WKT to convert</param>
    public static GeometryObject WktToGeometry(string wkt)
    {
      wkt = wkt.Trim().Replace(", ", ",");
      var match = Regex.Match(wkt, @"^([A-Z]+)\s*\((.+)\)$");
      if (match.Success)
      {
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
      }
      throw new NotImplementedException(match.Groups[1].Value);

    }

    /// <summary>
    /// MultiPolygon from WK.
    /// </summary>
    /// <returns>The MultiPolygon</returns>
    /// <param name="wkt">WKT.</param>
    public static MultiPolygon MultiPolygonFromWKT(string wkt)
    {
      var matches = Regex.Matches(wkt, @"\((\([^\)]+\))\)");
      var polygons = new List<Polygon>(matches.Count);
      for (var i = 0; i < matches.Count; i++)
      {
        var polygon = PolygonFromWKT(matches[i].Groups[1].Value);
        polygons.Add(polygon);
      }

      return new MultiPolygon(polygons);
    }

    /// <summary>
    /// Polygon from WK.
    /// </summary>
    /// <returns>The Polygon</returns>
    /// <param name="wkt">WKT.</param>
    public static Polygon PolygonFromWKT(string wkt)
    {
      var matches = Regex.Matches(wkt, @"\(([^\)]+)\)");
      var linestrings = new List<LineString>(matches.Count);
      for (var i = 0; i < matches.Count; i++)
      {
        var linestring = LineStringFromWKT(matches[i].Groups[1].Value);
        linestrings.Add(linestring);
      }

      return new Polygon(linestrings);
    }

    /// <summary>
    /// LineString from WK.
    /// </summary>
    /// <returns>The LineString</returns>
    /// <param name="wkt">WKT.</param>
    public static LineString LineStringFromWKT(string wkt)
    {
      var terms = wkt.Split(',');
      string[] values;
      var positions = new List<IPosition>(terms.Length);
      for (var i = 0; i < terms.Length; i++)
      {
        values = terms[i].Split(' ');
        var z = (values.Length > 2 ? values[2] : null);
        var geopos = new GeographicPosition(values[1], values[0], z);
        positions.Add(geopos);
      }

      var test = new LineString(positions);
      return test;
    }

    /// <summary>
    /// MultiLineString from WK.
    /// </summary>
    /// <returns>The MultiLineString</returns>
    /// <param name="wkt">WKT.</param>
    public static MultiLineString MultiLineStringFromWKT(string wkt)
    {
      var matches = Regex.Matches(wkt, @"\(([^\)]+)\)");
      var linestrings = new List<LineString>(matches.Count);
      for (var i = 0; i < matches.Count; i++)
      {
        var linestring = LineStringFromWKT(matches[i].Groups[1].Value);
        linestrings.Add(linestring);
      }

      return new MultiLineString(linestrings);
    }

    /// <summary>
    /// MultiPoint from WK.
    /// </summary>
    /// <returns>The MultiPoint</returns>
    /// <param name="wkt">WKT.</param>
    public static MultiPoint MultiPointFromWKT(string wkt)
    {
      var terms = wkt.Split(',');
      string[] values;
      var points = new List<IPosition>(terms.Length);
      for (var i = 0; i < terms.Length; i++)
      {
        values = terms[i].Split(' ');
        var z = (values.Length > 2 ? values[2] : null);
        var geopos = new GeographicPosition(values[1], values[0], z);
        points.Add(geopos);
      }
      return new MultiPoint(points);
    }

    /// <summary>
    /// Point from WK.
    /// </summary>
    /// <returns>The Point</returns>
    /// <param name="wkt">WKT.</param>
    public static Point PointFromWKT(string wkt)
    {
      string[] values;
      values = wkt.Split(' ');
      var z = (values.Length > 2 ? values[2] : null);
      var geopos = new GeographicPosition(values[1], values[0], z);
      return new Point(geopos);
    }

    /// <summary>
    /// Initialize a new IGemotry object from a standard WKT geometry
    /// </summary>
    /// <param name="wkt">The geometry in WKT to convert</param>
    public static GeometryObject GeoRSSToGeometry(XmlElement georss)
    {
      if (georss == null)
        throw new ArgumentNullException("GeoRSS Xml Element is null!");

      if (georss.LocalName == "point")
        return FromGeoRSSPoint(georss);

      if (georss.LocalName == "line")
        return FromGeoRSSLine(georss);

      if (georss.LocalName == "box")
        return FromGeoRSSBox(georss);

      if (georss.LocalName == "polygon")
        return FromGeoRSSPolygon(georss);

      if (georss.LocalName == "where")
        return GmlToGeometry((XmlElement) georss.FirstChild);

      throw new InvalidFormatException("GeoRSS type " + georss.LocalName + "is not supported");

    }

    private static Point FromGeoRSSPoint(XmlElement georss)
    {

      if (!IsGeoRSSNamespace(georss, true))
        return null;
      if (georss.LocalName != "point")
        return null;


      /* We retrieve gml:pos string */
      var georssText = georss.InnerText.Trim();

      /* gml:pos pattern:     
             * x1 y1
             * x1 y1 z1
             */
      var pos = georssText.Split(' ');
      if (pos.Length != 2)
        throw new InvalidFormatException("invalid GeoRSS representation: georss:point members are not 2 :" + georssText);

      return new Point(new GeographicPosition(pos[0], pos[1]));
    }

    private static LineString FromGeoRSSLine(XmlElement gml)
    {
      var position = new List<IPosition>();
      string georssline;

      if (!IsGeoRSSNamespace(gml, false))
        return null;

      /* We retrieve gml:pos string */
      georssline = gml.InnerText.Trim();

      /* georss:line pattern:         y1 x1, y2 x2
                 */
      var pos = georssline.Split(' ');
      if (pos.Length%2 != 0)
        throw new InvalidFormatException("invalid GeoRSS representation: georss:line members are not by 2 :" +
                                         georssline);
      for (var i = 0; i < pos.Length; i += 2)
      {
        position.Add(new GeographicPosition(pos[i + 0], pos[i + 1]));
      }

      if (position.Count < 2)
        throw new InvalidFormatException("invalid GML representation: LineString type must have at least 2 positions");

      return new LineString(position);
    }

    private static Polygon FromGeoRSSPolygon(XmlElement gml)
    {
      var polygon = new List<LineString>();

      polygon.Add(FromGeoRSSLine(gml));

      return new Polygon(polygon);
    }

    private static Polygon FromGeoRSSBox(XmlElement gml)
    {
      var position = new List<IPosition>();
      var polygon = new List<LineString>();
      string georssbox;

      if (!IsGeoRSSNamespace(gml, false))
        return null;

      /* We retrieve gml:pos string */
      georssbox = gml.InnerText.Trim();

      /* georss:box pattern:         y1,x1,y2,x2
                 */
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

    private static bool IsGeoRSSNamespace(XmlElement element, bool is_strict)
    {
      var ns = element.NamespaceURI;

      /*
             * If no namespace is available we could return true anyway
             * (because we work only on GML fragment, we don't want to
             *  'oblige' to add namespace on the geometry root node)
             */
      if (ns == null)
      {
        return !is_strict;
      }

      /*
             * Handle namespaces:
             *  - http://www.opengis.net/gml      (GML 3.1.1 and priors)
             *  - http://www.opengis.net/gml/3.2  (GML 3.2.1)
             */
      if (ns == "http://www.georss.org/georss" || ns == "http://www.georss.org/georss/10")
        return true;

      return false;
    }

    /// <summary>
    /// Get an XmlNameSpaceManager with the gmlnamesapces
    /// </summary>
    /// <returns>The xml namespace manager.</returns>
    public static XmlNamespaceManager GmlXmlNamespaceManager()
    {
      var namespaces = new XmlNamespaceManager(new XmlDocument().NameTable);
      namespaces.AddNamespace("gml", "http://www.opengis.net/gml");
      namespaces.AddNamespace("gml32", "http://www.opengis.net/gml/3.2");
      return namespaces;
    }

    /// <summary>
    /// Initialize a new IGeometry object from a GML XML element
    /// </summary>
    /// <param name="gml">The GML XML element convert</param>
    public static GeometryObject GmlToGeometry(XmlElement gml)
    {

      if (gml == null)
        throw new ArgumentNullException("GML Xml Element is null!");

      if (gml.LocalName == "Point")
        return FromGMLPoint(gml);

      if (gml.LocalName == "LineString")
        return FromGMLLineString(gml);

      if (gml.LocalName == "Curve")
        return FromGMLCurve(gml);

      if (gml.LocalName == "LinearRing")
        return FromGMLLinearRing(gml);

      if (gml.LocalName == "Polygon")
        return FromGMLPolygon(gml);

      if (gml.LocalName == "Triangle")
        return FromGMLTriangle(gml);

      if (gml.LocalName == "Surface")
        return FromGMLSurface(gml);

      if (gml.LocalName == "MultiPoint")
        return FromGMLMultiPoint(gml);

      if (gml.LocalName == "MultiLineString")
        return FromGMLMultiLineString(gml);

      if (gml.LocalName == "MultiCurve")
        return FromGMLMultiCurve(gml);

      if (gml.LocalName == "MultiPolygon")
        return FromGMLMultiPolygon(gml);

      if (gml.LocalName == "MultiSurface")
        return FromGMLMultiSurface(gml);

      if (gml.LocalName == "PolyhedralSurface")
        return FromGMLPolyhedralSurface(gml);

      if (gml.LocalName == "Tin" || gml.LocalName == "TriangulatedSurface")
        return FromGMLTin(gml);

      if (gml.LocalName == "MultiGeometry")
        return FromGMLMultiGeometry(gml);

      throw new InvalidFormatException("gml type " + gml.LocalName + "is not supported");

    }

    private static Point FromGMLPoint(XmlElement gml)
    {
      if (gml.ChildNodes.Count != 1)
        throw new InvalidFormatException("invalid GML representation: Point type must have 1 child");

      return new Point(FromGMLData(gml.ChildNodes)[0]);
    }

    private static LineString FromGMLLineString(XmlElement gml)
    {
      if (gml.ChildNodes.Count == 0)
        return new LineString(new List<IPosition>());

      var points = FromGMLData(gml.ChildNodes);

      if (points.Count < 2)
        throw new InvalidFormatException("invalid GML representation: LineString type must have at least 2 positions");

      return new LineString(points);
    }

    private static LineString FromGMLCurve(XmlElement gml)
    {
      var found = false;
      string interpolation;

      /* Looking for gml:segments */
      foreach (XmlNode node in gml)
      {
        var element = (XmlElement) node;
        if (!IsGMLNamespace(element, false))
          continue;
        if (element.LocalName == "segments")
        {
          found = true;
          break;
        }
      }

      if (!found)
        throw new InvalidFormatException("invalid GML representation: Curve type must have at least 1 segments");

      var positions = new List<IPosition>();

      /* Processing each gml:LineStringSegment */
      foreach (XmlNode node in gml)
      {
        var element = (XmlElement) node;
        if (!IsGMLNamespace(element, false))
          continue;
        if (element.LocalName == "LineStringSegment")
          continue;

        /* GML SF is resticted to linear interpolation  */
        interpolation = element.GetAttribute("interpolation");
        if (interpolation == "linear")
          throw new InvalidFormatException("invalid GML representation: interpolation of a curve cannot be linear");

        var pos = FromGMLData(element.ChildNodes);

        if (pos.Count < 2)
          throw new InvalidFormatException("invalid GML representation: curve segments must have at least 2 points");

        positions.AddRange(pos);

      }

      if (positions.Count == 0)
        throw new InvalidFormatException("invalid GML representation: curve is empty");

      /* Most common case, a single segment */
      if (positions.Count == 1)
        return new LineString(positions);

      /*
	         * "The curve segments are connected to one another, with the end point
	         *  of each segment except the last being the start point of the next
	         *  segment"  from  ISO 19107:2003 -> 6.3.16.1 (p43)
	         *
	         * So we must aggregate all the segments into a single one and avoid
	         * to copy the redundants points
	         */

      if (positions.Count > 1)
      {
        // TODO Aggregate stuff */
        throw new NotImplementedException("not implemented GML representation: curve with multi segment");
      }

      return new LineString(positions);

    }

    private static Polygon FromGMLLinearRing(XmlElement gml)
    {
      List<IPosition> positions;
      positions = FromGMLData(gml.ChildNodes);

      if (positions.Count < 4 || IsClosed2D(positions))
        throw new InvalidFormatException(
          "invalid GML representation: linearring is not a closed ring of minimum 4 positions");

      var linestring = new LineString(positions);
      var linestrings = new List<LineString>();
      linestrings.Add(linestring);

      return new Polygon(linestrings);
    }

    private static Polygon FromGMLPolygon(XmlElement gml)
    {
      var polygon = new List<LineString>();
      List<IPosition> positions = null;

      /* Polygon/outerBoundaryIs -> GML 2.1.2 */
      /* Polygon/exterior        -> GML 3.1.1 */
      foreach (XmlNode node in gml.SelectNodes("*[local-name()='outerBoundaryIs'] | *[local-name()='exterior']"))
      {

        var element = (XmlElement) node;

        foreach (XmlNode node1 in element)
        {
          var element1 = (XmlElement) node1;

          if (!IsGMLNamespace(element, true))
            continue;
          if (element1.LocalName == "LinearRing")
          {
            positions = FromGMLData(element1.ChildNodes);

            if (positions.Count < 4 || !IsClosed2D(positions))
              throw new InvalidFormatException(
                "invalid GML representation: polygon outer is not a closed ring of minimum 4 positions");
          }
        }
      }

      if (positions == null)
        throw new InvalidFormatException("invalid GML representation: polygon outer is empty");

      polygon.Add(new LineString(positions));

      /* Polygon/outerBoundaryIs -> GML 2.1.2 */
      /* Polygon/exterior        -> GML 3.1.1 */
      foreach (XmlNode node in gml.SelectNodes("innerBoundaryIs | interior"))
      {

        var element = (XmlElement) node;

        foreach (XmlNode node1 in element)
        {
          var element1 = (XmlElement) node1;

          if (!IsGMLNamespace(element, true))
            continue;
          if (element1.LocalName == "LinearRing")
          {
            positions = FromGMLData(element1.ChildNodes);

            if (positions.Count < 4 || IsClosed2D(positions))
              throw new InvalidFormatException(
                "invalid GML representation: polygon inner is not a closed ring of minimum 4 positions");
          }
        }

        polygon.Add(new LineString(positions));
      }

      return new Polygon(polygon);
    }

    private static Polygon FromGMLTriangle(XmlElement gml)
    {
      // TODO implement FromGMLTriangle
      throw new NotImplementedException("GML Triangle is not supported yet.");
    }

    private static Polygon FromGMLSurface(XmlElement gml)
    {

      /* Looking for gml:patches */
      var element = (XmlElement) gml.SelectSingleNode("patches");
      if (element == null)
        throw new InvalidFormatException("invalid GML representation: surface must have patches");

      if (element.SelectNodes("PolygonPatch").Count > 1)
      {
        throw new NotImplementedException("Multi patch is not supported yet.");
      }

      return FromGMLPatch(element);

    }

    private static Polygon FromGMLPatch(XmlElement gml)
    {
      /* PolygonPatch */
      if (gml.LocalName != "PolygonPatch")
        throw new InvalidFormatException("invalid GML representation: patch must be PolygonPatch");

      /* GML SF is resticted to planar interpolation  */
      var interpolation = gml.GetAttribute("interpolation");
      if (interpolation != null)
      {
        if (interpolation != "planar")
          throw new InvalidFormatException("invalid GML representation: interpolation must be planar");
      }

      return FromGMLPolygon(gml);
    }

    /// <summary>
    private static MultiPoint FromGMLMultiPoint(XmlElement gml)
    {
      var points = new List<IPosition>();

      if (gml.ChildNodes == null)
        return new MultiPoint(null);

      /* MultiPoint/pointMember */
      foreach (XmlNode node in gml.SelectNodes("gml:pointMember", GmlXmlNamespaceManager()))
      {
        points.AddRange(FromGMLData(node.ChildNodes));

      }
      /* MultiPoint/pointMember */
      foreach (XmlNode node in gml.SelectNodes("gml32:pointMember", GmlXmlNamespaceManager()))
      {
        points.AddRange(FromGMLData(node.ChildNodes));

      }

      return new MultiPoint(points);
    }

    private static MultiLineString FromGMLMultiLineString(XmlElement gml)
    {

      var linestrings = new List<LineString>();

      /* MultiLineString/lineStringMember */
      foreach (XmlNode node in gml.SelectNodes("gml:lineStringMember/*", GmlXmlNamespaceManager()))
      {
        linestrings.Add(FromGMLLineString((XmlElement) node));
      }

      /* MultiLineString/lineStringMember */
      foreach (XmlNode node in gml.SelectNodes("gml32:lineStringMember/*", GmlXmlNamespaceManager()))
      {
        linestrings.Add(FromGMLLineString((XmlElement) node));
      }

      return new MultiLineString(linestrings);
    }

    private static MultiLineString FromGMLMultiCurve(XmlElement gml)
    {
      var linestrings = new List<LineString>();

      /* MutltiCurve/curveMember/LineString */
      foreach (XmlNode node in gml.SelectNodes("gml:curveMember/gml:LineString", GmlXmlNamespaceManager()))
      {
        linestrings.Add(FromGMLLineString((XmlElement) node));
      }
      /* MutltiCurve/curveMember/LineString */
      foreach (XmlNode node in gml.SelectNodes("gml32:curveMember/gml32:LineString", GmlXmlNamespaceManager()))
      {
        linestrings.Add(FromGMLLineString((XmlElement) node));
      }

      /* MutltiCurve/curveMember/Curve */
      foreach (XmlNode node in gml.SelectNodes("gml:curveMember/gml:Curve", GmlXmlNamespaceManager()))
      {
        linestrings.Add(FromGMLCurve((XmlElement) node));
      }
      /* MutltiCurve/curveMember/Curve */
      foreach (XmlNode node in gml.SelectNodes("gml32:curveMember/gml32:Curve", GmlXmlNamespaceManager()))
      {
        linestrings.Add(FromGMLCurve((XmlElement) node));
      }

      return new MultiLineString(linestrings);
    }

    private static MultiPolygon FromGMLMultiPolygon(XmlElement gml)
    {
      var polygons = new List<Polygon>();

      /* MultiPolygon/polygonMember */
      foreach (XmlNode node in gml.SelectNodes("gml:polygonMember/*", GmlXmlNamespaceManager()))
      {
        polygons.Add(FromGMLPolygon((XmlElement) node));
      }
      /* MultiPolygon/polygonMember */
      foreach (XmlNode node in gml.SelectNodes("gml32:polygonMember/*", GmlXmlNamespaceManager()))
      {
        polygons.Add(FromGMLPolygon((XmlElement) node));
      }

      return new MultiPolygon(polygons);
    }

    private static MultiPolygon FromGMLMultiSurface(XmlElement gml)
    {
      var polygons = new List<Polygon>();

      /* MultiSurface/surfaceMember */
      foreach (XmlNode node in gml.SelectNodes("gml:surfaceMembers/*", GmlXmlNamespaceManager()))
      {
        polygons.Add(FromGMLPolygon((XmlElement) node));
      }
      /* MultiSurface/surfaceMember */
      foreach (XmlNode node in gml.SelectNodes("gml32:surfaceMembers/*", GmlXmlNamespaceManager()))
      {
        polygons.Add(FromGMLPolygon((XmlElement) node));
      }

      return new MultiPolygon(polygons);
    }

    private static MultiPolygon FromGMLPolyhedralSurface(XmlElement gml)
    {
      // TODO implement FromGMLPolyhedralSurface
      throw new NotImplementedException("GML PolyhedralSurface is not supported yet.");
    }

    private static Polygon FromGMLTin(XmlElement gml)
    {
      // TODO implement FromGMLTin
      throw new NotImplementedException("GML Tin is not supported yet.");
    }

    private static GeometryCollection FromGMLMultiGeometry(XmlElement gml)
    {
      var geometries = new List<GeometryObject>();

      /*
             * In GML 2.1.2 pointMember, lineStringMember and
             * polygonMember are parts of geometryMember
             * substitution group
             */
      foreach (XmlNode node in gml.SelectNodes("gml:pointMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml:lineStringMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml:polygonMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml:geometryMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml32:pointMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml32:lineStringMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml32:polygonMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }
      foreach (XmlNode node in gml.SelectNodes("gml32:geometryMember/*", GmlXmlNamespaceManager()))
      {
        geometries.Add(GmlToGeometry((XmlElement) node));
      }

      return new GeometryCollection(geometries);
    }

    private static List<IPosition> FromGMLData(XmlNodeList nodes)
    {
      var position = new List<IPosition>();

      foreach (XmlNode node in nodes)
      {
        var element = (XmlElement) node;

        if (element.LocalName == "pos")
          position.Add(FromGMLPos(element));

        if (element.LocalName == "posList")
          position.AddRange(FromGMLPosList(element));

        if (element.LocalName == "coordinates")
          position.AddRange(FromGMLCoordinates(element));

        if (element.LocalName == "coord")
          position.Add(FromGMLCoord(element));

        if (element.LocalName == "pointRep" || element.LocalName == "pointProperty")
        {

          var found = false;

          foreach (XmlNode node1 in element.ChildNodes)
          {
            var el = (XmlElement) node1;

            if (!IsGMLNamespace(el, true))
              continue;

            if (el.LocalName == "Point")
            {
              found = true;
              break;
            }

          }
          if (!found)
            throw new InvalidFormatException(
              "invalid GML representation: pointRep or pointProperty type must have at least 1 child");

          return FromGMLData(element.ChildNodes);

        }

      }
      return position;
    }

    private static IPosition FromGMLPos(XmlElement gml)
    {
      IPosition position;
      int dim;
      string gmlpos;

      if (!IsGMLNamespace(gml, true))
        return null;
      if (gml.LocalName != "pos")
        return null;

      var dimension = gml.GetAttribute("srsDimension");

      if (dimension == "") /* in GML 3.0.0 it was dimension */
        dimension = gml.GetAttribute("dimension");
      if (dimension == "")
        dim = 2; /* We assume that we are in 2D */
      else
      {
        dim = int.Parse(dimension);
        if (dim < 2 || dim > 3)
          throw new InvalidFormatException("invalid GML representation: gml:pos dimension equals " + dim);
      }

      /* We retrieve gml:pos string */
      gmlpos = gml.InnerText.Trim();

      /* gml:pos pattern:     
			 * x1 y1
             * x1 y1 z1
             */
      var pos = gmlpos.Split(' ');
      position = new GeographicPosition(pos[0], pos[1], pos[2]);
      return position;
    }

    private static List<IPosition> FromGMLPosList(XmlElement gml)
    {
      var position = new List<IPosition>();
      int dim;
      string gmlpos, dimension;

      if (!IsGMLNamespace(gml, false))
        return null;

      dimension = gml.GetAttribute("srsDimension");

      if (dimension == "") /* in GML 3.0.0 it was dimension */
        dimension = gml.GetAttribute("dimension");
      if (dimension == "")
        dim = 2; /* We assume that we are in 2D */
      else
      {
        dim = int.Parse(dimension);
        if (dim < 2 || dim > 3)
          throw new InvalidFormatException("invalid GML representation: gml:pos dimension equals " + dim);
      }

      /* We retrieve gml:pos string */
      gmlpos = gml.InnerText.Trim();

      /* gml:posList pattern:         y1 x1 y2 x2
         		 *                              y1 x1 z1 y2 x2 z2
         		 */
      var pos = gmlpos.Split(' ');

      for (var i = 0; i < pos.Length; i += dim)
      {
        if (dim == 2)
          position.Add(new GeographicPosition(pos[i + 0], pos[i + 1], null));
        if (dim == 3)
          position.Add(new GeographicPosition(pos[i + 0], pos[i + 1], pos[i + 2]));
      }
      return position;
    }

    private static IPosition FromGMLCoord(XmlElement element)
    {
      double? x = null, y = null, z = null;

      foreach (XmlElement el in element.ChildNodes)
      {
        if (!IsGMLNamespace(el, false))
          continue;

        if (el.LocalName == "X")
          x = double.Parse(el.InnerText);

        if (el.LocalName == "Y")
          y = double.Parse(el.InnerText);

        if (el.LocalName == "Z")
          z = double.Parse(el.InnerText);
      }

      /* Check dimension consistancy */
      if (x == null || y == null)
        throw new InvalidFormatException("invalid GML representation: gml:coord missing X or Y");

      var geopos = new GeographicPosition(y.Value, x.Value, z.Value);
      return geopos;

    }

    private static List<IPosition> FromGMLCoordinates(XmlElement element)
    {
      var position = new List<IPosition>();
      string gmlcoord, gmlts, gmlcs, gmldec;
      char ts = ' ', cs = ',', dec = '.';

      gmlcoord = element.InnerText;

      /* Retrieve separator between coordinates tuples */
      gmlts = element.GetAttribute("ts");
      if (char.TryParse(gmlts, out ts) != true)
        ts = ' ';

      /* Retrieve separator between each coordinate */
      gmlcs = element.GetAttribute("cs");
      if (char.TryParse(gmlcs, out cs) != true)
      {
        cs = ',';
      }

      /* Retrieve decimal separator */
      gmldec = element.GetAttribute("decimal");
      if (char.TryParse(gmldec, out dec) != true)
        dec = '.';

      if (cs == ts || cs == dec || ts == dec)
        throw new InvalidFormatException("invalid GML representation: gml:coordinates ambiguity in separators");

      /* We retrieve gml:coord string */
      gmlcoord = element.InnerText.Trim();
      if (gmlcoord == null || gmlcoord == "")
        throw new InvalidFormatException("invalid GML representation: gml:coordinates is empty");

      var coordinates = gmlcoord.Split(ts);

      foreach (var coord in coordinates)
      {

        var pos = coord.Split(cs);

        var x = double.Parse(pos[1]);
        var y = double.Parse(pos[0]);
        double? z = null;
        if (pos.Length > 2)
          z = double.Parse(pos[2]);

        position.Add(new GeographicPosition(y, x, z));

      }
      return position;

    }

    private static bool IsGMLNamespace(XmlElement element, bool is_strict)
    {
      var ns = element.NamespaceURI;

      /*
         	 * If no namespace is available we could return true anyway
         	 * (because we work only on GML fragment, we don't want to
         	 *  'oblige' to add namespace on the geometry root node)
         	 */
      if (ns == null)
      {
        return !is_strict;
      }

      /*
	         * Handle namespaces:
	         *  - http://www.opengis.net/gml      (GML 3.1.1 and priors)
	         *  - http://www.opengis.net/gml/3.2  (GML 3.2.1)
	         */
      if (ns == "http://www.opengis.net/gml" || ns == "http://www.opengis.net/gml/3.2")
        return true;

      return false;
    }

    private static bool IsClosed2D(List<IPosition> positions)
    {
      return positions[0].Equals(positions[positions.Count - 1]);
    }

    public static MultiPolygon SplitWorldExtent(MultiPolygon mpoly)
    {

      var newmpoly = new MultiPolygon();

      foreach (var poly in mpoly.Polygons)
      {
        newmpoly.Polygons.Add(SplitWorldExtent(poly));
      }

      return newmpoly;
    }

    public static Polygon SplitWorldExtent(Polygon poly)
    {

      var newpoly = new Polygon();

      foreach (var lineString in poly.LineStrings)
      {
        newpoly.LineStrings.Add(SplitWorldExtent(lineString));
      }

      return newpoly;

    }

    public static LineString SplitWorldExtent(LineString lineString)
    {

      var newLineString = new LineString();

      var previous_position = (GeographicPosition) lineString.Positions[0];
      newLineString.Positions.Add(previous_position);

      for (var i = 1; i < lineString.Positions.Count; i++)
      {

        var current_position = (GeographicPosition) lineString.Positions[i];
        if ((current_position.Longitude - previous_position.Longitude < -90) ||
            (current_position.Longitude - previous_position.Longitude > 90))
        {

          double new_longitude;
          double new_latitude;
          double? new_altitude;
          double new_longitude2;
          double new_latitude2;
          double? new_altitude2;

          if (previous_position.Longitude > 0)
          {
            new_longitude = 180;
            new_longitude2 = -180;
          }
          else
          {
            new_longitude = -180;
            new_longitude2 = 180;
          }
          // Calaculate the latitude to be linear with the next point
          new_latitude = (current_position.Latitude - previous_position.Latitude)*
                         (-1*new_longitude - previous_position.Longitude + 2*new_longitude)/
                         (current_position.Longitude - previous_position.Longitude + 2*new_longitude) +
                         previous_position.Latitude;
          new_latitude2 = new_latitude;

          new_altitude = new_altitude2 = current_position.Altitude;

          var new_position1 = new GeographicPosition(new_latitude, new_longitude, new_altitude);
          var new_position2 = new GeographicPosition(new_latitude2, new_longitude2, new_altitude2);
          newLineString.Positions.Add(new_position1);
          newLineString.Positions.Add(new_position2);
        }
        newLineString.Positions.Add(current_position);
        previous_position = current_position;
      }

      return newLineString;

    }
  }

  public class InvalidFormatException : Exception
  {
    public InvalidFormatException(string message) : base(message)
    {
    }
  }
}
