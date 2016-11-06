//
//  MultiPolygon.cs
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
using Newtonsoft.Json;

namespace Terradue.GeoJson.Geometry
{
  /// <summary>
  ///   Defines the <see cref="http://geojson.org/geojson-spec.html#multipolygon">MultiPolygon</see> type.
  /// </summary>
  public class MultiPolygon : GeometryObject
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.MultiPolygon" /> class.
    /// </summary>
    public MultiPolygon()
    {
      Polygons = new List<Polygon>();
      Type = GeoJsonObjectType.MultiPolygon;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="MultiPolygon" /> class.
    /// </summary>
    /// <param name="polygons">The polygons contained in this MultiPolygon.</param>
    public MultiPolygon(List<Polygon> polygons = null)
    {
      Polygons = polygons ?? new List<Polygon>();
      Type = GeoJsonObjectType.MultiPolygon;
    }

    /// <summary>
    ///   Gets the list of Polygons enclosed in this MultiPolygon.
    /// </summary>
    [JsonIgnore]
    public List<Polygon> Polygons { get; set; }

    /// <summary>
    ///   Gets the coordinates
    /// </summary>
    [JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
    public List<List<List<List<double>>>> Coordinates
    {
      get
      {
        return Polygons.Select(polygon => polygon.Coordinates).ToList();
      }

      set
      {
        foreach (var list in value)
        {
          var polygon = new Polygon();
          polygon.Coordinates = list;
          Polygons.Add(polygon);
        }
      }
    }
  }
}