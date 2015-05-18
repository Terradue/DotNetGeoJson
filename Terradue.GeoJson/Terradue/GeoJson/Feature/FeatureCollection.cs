//
//  FeatureCollection.cs
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

namespace Terradue.GeoJson.Feature
{
  /// <summary>
  /// Defines the FeatureCollection type.
  /// </summary>
  [DataContract]
  public class FeatureCollection : GeoJsonObject
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="FeatureCollection"/> class.
    /// </summary>
    public FeatureCollection()
    {
      Features = new List<Feature>();
      Type = GeoJsonObjectType.FeatureCollection;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FeatureCollection"/> class.
    /// </summary>
    /// <param name="features">The features.</param>
    public FeatureCollection(List<Feature> features)
    {
      Features = features;
      Type = GeoJsonObjectType.FeatureCollection;
    }

    /// <summary>
    /// Gets the features.
    /// </summary>
    /// <value>The features.</value>
    [DataMember(Name = "features", IsRequired = true)]
    public List<Feature> Features { get; private set; }

    /// <summary>
    /// Gets the properties.
    /// </summary>
    /// <value>The properties.</value>
    [DataMember(Name = "properties")]
    public Dictionary<string, object> Properties { get; set; }
  }
}
