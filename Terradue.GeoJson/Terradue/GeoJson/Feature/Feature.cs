//
//  Feature.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

using System.Collections.Generic;
using Newtonsoft.Json;
using Terradue.GeoJson.Converter;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Feature
{
  /// <summary>
  ///   A GeoJson <see cref="http://geojson.org/geojson-spec.html#feature-objects">Feature Object</see>.
  /// </summary>
  public class Feature : GeoJsonObject
  {
    public Feature()
    {
      Properties = new Dictionary<string, object>();
      Type = GeoJsonObjectType.Feature;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="Feature" /> class.
    /// </summary>
    /// <param name="geometry">The Geometry Object.</param>
    /// <param name="properties">The properties.</param>
    public Feature(GeometryObject geometry, Dictionary<string, object> properties)
    {
      if (properties != null)
        Properties = properties;
      else
        Properties = new Dictionary<string, object>();
      Geometry = geometry;
      Type = GeoJsonObjectType.Feature;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="Terradue.GeoJson.Feature.Feature" /> class.
    /// </summary>
    /// <param name="properties">Properties.</param>
    public Feature(Dictionary<string, object> properties) : this(null, properties)
    {
    }

    /// <summary>
    ///   Gets or sets the id.
    /// </summary>
    /// <value>The handle.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    ///   Gets the properties.
    /// </summary>
    /// <value>The properties.</value>
    [JsonProperty(PropertyName = "properties")]
    public Dictionary<string, object> Properties { get; set; }

    /// <summary>
    ///   Gets or sets the geometry.
    /// </summary>
    /// <value>
    ///   The geometry.
    /// </value>
    //[JsonConverter(typeof(GeometryConverter))]
    [JsonProperty(PropertyName = "geometry")]
    [JsonConverter(typeof(GeometryConverter))]
    public GeometryObject Geometry { get; set; }
  }
}