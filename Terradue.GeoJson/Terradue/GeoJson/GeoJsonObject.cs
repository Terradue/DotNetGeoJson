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

using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Terradue.GeoJson.CoordinateReferenceSystem;

namespace Terradue.GeoJson
{
  /// <summary>
    /// Base class for all IGeometryObject implementing types
    /// </summary>
    [DataContract]
	public abstract class GeoJsonObject : IGeoJsonObject
    {

        /// <summary>
        /// Gets the (mandatory) type of the <see cref="http://geojson.org/geojson-spec.html#geojson-objects">GeoJson Object</see>.
        /// </summary>
        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName="type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
		public GeoJsonObjectType Type { get; internal set; }

        /// <summary>
        /// Gets or sets the (optional) <see cref="http://geojson.org/geojson-spec.html#coordinate-reference-system-objects">Coordinate Reference System Object</see>.
        /// </summary>
        /// <value>
        /// The Coordinate Reference System Objects.
        /// </value>
        [JsonProperty(PropertyName="crs")]
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
        [JsonProperty(PropertyName="bbox")]
		public List<double> BoundingBoxes { get; set; }
    }
}
