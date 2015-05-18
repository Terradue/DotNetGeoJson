//
//  MultiPolygonFeature.cs
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
using ServiceStack.Text;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Feature
{
  /// <summary>
  /// A GeoJSON <see cref="http://geojson.org/geojson-spec.html#feature-objects">Feature Object</see>.
  /// </summary>
  [DataContract]
  public class MultiPolygonFeature : Feature
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Feature"/> class.
    /// </summary>
    /// <param name="geometry">The Geometry Object.</param>
    /// <param name="properties">The properties.</param>
    public MultiPolygonFeature(MultiPolygon geometry, Dictionary<string, object> properties = null)
      : base(geometry, properties)
    {
      Geometry = geometry;
    }

    /// <summary>
    /// Create a feature from a json string.
    /// </summary>
    /// <returns>The json.</returns>
    /// <param name="json">Json.</param>
    public new static MultiPolygonFeature ParseJson(string json)
    {

      var geometry = new MultiPolygon();
      var mpObj = JsonObject.Parse(json);

      geometry = mpObj.JsonTo<MultiPolygon>("geometry");

      var mp = new MultiPolygonFeature(geometry, mpObj.JsonTo<Dictionary<string, object>>("properties"));
      mp.Id = mpObj.JsonTo<string>("id");
      return mp;

    }

    /// <summary>
    /// Gets or sets the geometry.
    /// </summary>
    /// <value>
    /// The geometry.
    /// </value>
    [DataMember(Name = "geometry")]
    public new MultiPolygon Geometry { get; set; }
  }
}
