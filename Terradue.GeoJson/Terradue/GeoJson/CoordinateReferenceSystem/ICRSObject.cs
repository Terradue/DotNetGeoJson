//
//  ICRSObject.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

namespace Terradue.GeoJson.CoordinateReferenceSystem
{
  /// <summary>
  /// Base Interface for CRSBase Object types.
  /// </summary>
  public interface ICRSObject
  {
    /// <summary>
    /// Gets the CRS type.
    /// </summary>
    CRSType Type { get; }
  }
}
