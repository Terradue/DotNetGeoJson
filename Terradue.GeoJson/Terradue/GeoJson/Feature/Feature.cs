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
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.Text;
using Terradue.GeoJson.Geometry;

namespace Terradue.GeoJson.Feature
{
  /// <summary>
  /// A GeoJson <see cref="http://geojson.org/geojson-spec.html#feature-objects">Feature Object</see>.
  /// </summary>
  public abstract class Feature : GeoJsonObject
  {
    public Feature()
    {
      Properties = new Dictionary<string, object>();
      Type = GeoJsonObjectType.Feature;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Feature"/> class.
    /// </summary>
    /// <param name="geometry">The Geometry Object.</param>
    /// <param name="properties">The properties.</param>
    public Feature(IGeometryObject geometry, Dictionary<string, object> properties)
    {
      Properties = properties ?? new Dictionary<string, object>();
      Geometry = geometry;
      Type = GeoJsonObjectType.Feature;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Terradue.GeoJson.Feature.Feature"/> class.
    /// </summary>
    /// <param name="properties">Properties.</param>
    internal Feature(Dictionary<string, object> properties) : this(null, properties)
    {
    }

    /// <summary>
    /// Create a feature from a json string.
    /// </summary>
    /// <returns>The json.</returns>
    /// <param name="json">Json.</param>
    public static Feature ParseJson(string json)
    {

      var jsonFeature = JsonObject.Parse(json);
      var geometry = jsonFeature.Object("geometry");
      if (geometry == null)
        return JsonSerializer.DeserializeFromString<NoGeometryFeature>(json);
      Feature feature;
      var geometryType = geometry.Get<string>("type");
      switch (geometryType)
      {
        case null:
          feature = json.FromJson<NoGeometryFeature>();
          break;
        case "MultiPolygon":
          feature = json.FromJson<MultiPolygonFeature>();
          break;
        case "Polygon":
          feature = json.FromJson<PolygonFeature>();
          break;
        case "MultiLineString":
          feature = json.FromJson<MultiLineStringFeature>();
          break;
        case "LineString":
          feature = json.FromJson<LineStringFeature>();
          break;
        case "MultiPoint":
          feature = json.FromJson<MultiPointFeature>();
          break;
        case "Point":
          feature = json.FromJson<PointFeature>();
          break;
        default:
          throw new InvalidFormatException(string.Format("Not a valid GeoSon geometry type: {0}", geometryType));
      }

      return feature;

    }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    /// <value>The handle.</value>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets the properties.
    /// </summary>
    /// <value>The properties.</value>
    [DataMember(Name = "properties")]
    public Dictionary<string, object> Properties { get; set; }

    /// <summary>
    /// Gets or sets the geometry.
    /// </summary>
    /// <value>
    /// The geometry.
    /// </value>
    //[JsonConverter(typeof(GeometryConverter))]
    [DataMember(Name = "geometry")]
    public IGeometryObject Geometry { get; set; }
  }
}
