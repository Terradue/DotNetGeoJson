//
//  CRSBase.cs
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

namespace Terradue.GeoJson.CoordinateReferenceSystem
{
  /// <summary>
  ///   Base class for all IGeometryObject implementing types
  /// </summary>
  [DataContract]
  public abstract class CRSBase : ICRSObject
  {
    /// <summary>
    ///   Gets the properties.
    /// </summary>
    [DataMember(Name = "properties", IsRequired = true)]
    public Dictionary<string, object> Properties { get; internal set; }

    /// <summary>
    ///   Gets the type of the GeometryObject object.
    /// </summary>
    [DataMember(Name = "type", IsRequired = true)]
    public CRSType Type { get; internal set; }
  }
}