//
//  MultiLineString.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Terradue.GeoJson.Geometry
{
  /// <summary>
  ///   Defines the <see cref="http://geojson.org/geojson-spec.html#multilinestring">MultiLineString</see> type.
  /// </summary>
  [DataContract]
  public class MultiLineString : GeometryObject
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.MultiLineString" /> class.
    /// </summary>
    public MultiLineString()
    {
      LineStrings = new List<LineString>();
      Type = GeoJsonObjectType.MultiLineString;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="MultiLineString" /> class.
    /// </summary>
    /// <param name="coordinates">The coordinates.</param>
    public MultiLineString(List<LineString> lineStrings)
    {
      LineStrings = lineStrings ?? new List<LineString>();
      Type = GeoJsonObjectType.MultiLineString;
    }

    /// <summary>
    ///   Gets or sets the line strings.
    /// </summary>
    /// <value>The line strings.</value>
    public List<LineString> LineStrings { get; set; }

    [DataMember(Name = "coordinates")]
    public List<List<List<double>>> Coordinates
    {
      get
      {
        var coordinates = new List<List<List<double>>>();
        foreach (var linestring in LineStrings)
        {
          coordinates.Add(linestring.Coordinates);
        }
        return coordinates;
      }

      set
      {
        foreach (var list in value)
        {
          var linestring = new LineString {Coordinates = list};
          LineStrings.Add(linestring);
        }
      }
    }
  }
}