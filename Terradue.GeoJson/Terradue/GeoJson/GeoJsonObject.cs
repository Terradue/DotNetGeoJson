//
//  GeoJsonObject.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

using System.Runtime.Serialization;
using Terradue.GeoJson.CoordinateReferenceSystem;

namespace Terradue.GeoJson
{
  /// <summary>
  /// Base class for all IGeometryObject implementing types
  /// </summary>
  [DataContract]
  public abstract class GeoJsonObject : IGeoJsonObject, ISerializable
  {

    /// <summary>
    /// Gets the (mandatory) type of the <see cref="http://geojson.org/geojson-spec.html#geojson-objects">GeoJson Object</see>.
    /// </summary>
    /// <value>
    /// The type of the object.
    /// </value>
    [DataMember(Name = "type")]
    public GeoJsonObjectType Type { get; internal set; }

    /// <summary>
    /// Gets or sets the (optional) <see cref="http://geojson.org/geojson-spec.html#coordinate-reference-system-objects">Coordinate Reference System Object</see>.
    /// </summary>
    /// <value>
    /// The Coordinate Reference System Objects.
    /// </value>
    [DataMember(Name = "crs")]
    public ICRSObject CRS { get; set; }

    /// <summary>
    /// Gets or sets the (optional) <see cref="http://geojson.org/geojson-spec.html#coordinate-reference-system-objects">Bounding Boxes</see>.
    /// </summary>
    /// <value>
    /// The value of the bbox member must be a 2*n array where n is the number of dimensions represented in the
    /// contained geometries, with the lowest values for all axes followed by the highest values.
    /// The axes order of a bbox follows the axes order of geometries.
    /// In addition, the coordinate reference system for the bbox is assumed to match the coordinate reference
    /// system of the GeoJson object of which it is a member.
    /// </value>
    [DataMember(Name = "bbox")]
    public double[] BoundingBoxes { get; set; }

    #region ISerializable implementation

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue("mime-type", "application/json");
    }

    #endregion
  }
}
