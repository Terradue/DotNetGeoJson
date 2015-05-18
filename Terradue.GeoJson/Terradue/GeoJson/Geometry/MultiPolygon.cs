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

namespace Terradue.GeoJson.Geometry
{
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System;

  /// <summary>
  /// Defines the <see cref="http://geojson.org/geojson-spec.html#multipolygon">MultiPolygon</see> type.
  /// </summary>
  [DataContract]
  public class MultiPolygon : GeometryObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.MultiPolygon"/> class.
    /// </summary>
    public MultiPolygon()
    {
      this.Polygons = new List<Polygon>();
      this.Type = GeoJsonObjectType.MultiPolygon;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MultiPolygon"/> class.
    /// </summary>
    /// <param name="polygons">The polygons contained in this MultiPolygon.</param>
    public MultiPolygon(List<Polygon> polygons = null)
    {
      this.Polygons = polygons ?? new List<Polygon>();
      this.Type = GeoJsonObjectType.MultiPolygon;
    }

    /// <summary>
    /// Gets the list of Polygons enclosed in this MultiPolygon.
    /// </summary>
    public List<Polygon> Polygons { get; set; }

    /// <summary>
    /// Gets the coordinates
    /// </summary>
    [DataMember(Name = "coordinates")]
    public List<List<List<List<double>>>> Coordinates
    {

      get
      {
        var coordinates = new List<List<List<List<double>>>>();
        foreach (var polygon in Polygons)
        {
          coordinates.Add(polygon.Coordinates);
        }
        return coordinates;
      }

      set
      {
        foreach (var list in value)
        {
          var polygon = new Polygon();
          polygon.Coordinates = list;
          this.Polygons.Add(polygon);
        }
      }
    }
  }
}
