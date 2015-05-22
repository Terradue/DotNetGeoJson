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

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Terradue.GeoJson.Geometry
{
  /// <summary>
  ///   In geography, a point refers to a Position on a map, expressed in latitude and longitude.
  /// </summary>
  /// <seealso cref="http://geojson.org/geojson-spec.html#point" />
  [DataContract]
  public class Point : GeometryObject
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="Point" /> class.
    /// </summary>
    /// <param name="coordinates">The Position.</param>
    public Point(IPosition coordinates)
    {
      if (coordinates == null)
      {
        throw new ArgumentNullException("coordinates");
      }

      Position = coordinates;
      Type = GeoJsonObjectType.Point;
    }

    internal Point()
    {
      Position = null;
      Type = GeoJsonObjectType.Point;
    }

    /// <summary>
    ///   Gets or sets the position.
    /// </summary>
    /// <value>The position.</value>
    public IPosition Position { get; set; }

    /// <summary>
    ///   Gets the Coordinate(s).
    /// </summary>
    /// <value>The Coordinates.</value>
    //        [JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
    //        [JsonConverter(typeof(PositionConverter))]
    [DataMember(Name = "coordinates")]
    public List<double> Coordinates
    {
      get
      {
        var coordinates = new List<double>();
        coordinates.Add((double) ((GeographicPosition) Position).Coordinates[1]);
        coordinates.Add((double) ((GeographicPosition) Position).Coordinates[0]);
        return coordinates;
      }

      set { }
    }
  }
}