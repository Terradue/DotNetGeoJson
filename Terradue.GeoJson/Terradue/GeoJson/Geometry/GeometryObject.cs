//
//  GeometryObject.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terradue.GeoJson.Geometry {
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using System;

    /// <summary>
    /// Base abstract class for GeometryObject types.
    /// </summary>
    public abstract class GeometryObject : IGeometryObject {
        /// <summary>
        /// Gets the (mandatory) type of the <see cref="http://geojson.org/geojson-spec.html#geometry-objects">GeoJSON Object</see>.
        /// However, for <see cref="http://geojson.org/geojson-spec.html#geometry-objects">GeoJSON Objects</see> only
        /// the 'Point', 'MultiPoint', 'LineString', 'MultiLineString', 'Polygon', 'MultiPolygon', or 'GeometryCollection' types are allowed.
        /// </summary>
        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GeoJsonObjectType Type { get; set; }
    }
}
