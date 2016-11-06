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
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

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
    /// <param name="lineStrings">The linestring list.</param>
    public MultiLineString(List<LineString> lineStrings)
    {
      LineStrings = lineStrings ?? new List<LineString>();
      Type = GeoJsonObjectType.MultiLineString;
    }

    /// <summary>
    ///   Gets or sets the line strings.
    /// </summary>
    /// <value>The line strings.</value>
    [JsonIgnore]
    public List<LineString> LineStrings { get; set; }

    [JsonProperty(PropertyName = "coordinates")]
    public List<List<List<double>>> Coordinates
    {
      get
      {
        return LineStrings.Select(linestring => linestring.Coordinates).ToList();
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