//
//  IGeometryObject.cs
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
  using System.Runtime.Serialization;
  using System;

  /// <summary>
  /// Base Interface for GeometryObject types.
  /// </summary>
  public interface IGeometryObject
  {
    /// <summary>
    /// Gets the (mandatory) type of the <see cref="http://geojson.org/geojson-spec.html#geometry-objects">GeoJSON Object</see>.
    /// However, for <see cref="http://geojson.org/geojson-spec.html#geometry-objects">GeoJSON Objects</see> only
    /// the 'Point', 'MultiPoint', 'LineString', 'MultiLineString', 'Polygon', 'MultiPolygon', or 'GeometryCollection' types are allowed.
    /// </summary>
    /// <value>
    /// The type of the object.
    /// </value>
    GeoJsonObjectType Type { get; }
  }
}
