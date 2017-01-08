//
//  GeometryCollection.cs
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

namespace Terradue.GeoJson.Geometry {
  /// <summary>
    /// Defines the <see cref="http://geojson.org/geojson-spec.html#geometry-collection">GeometryCollection</see> type.
    /// </summary>
    [DataContract]
    public class GeometryCollection : GeometryObject, IGeometryObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection"/> class.
        /// </summary>
        /// <param name="geometries">The geometries contained in this GeometryCollection.</param>
        public GeometryCollection(List<GeometryObject> geometries = null) {
            Geometries = geometries ?? new List<GeometryObject>();
            Type = GeoJsonObjectType.GeometryCollection;
        }

        /// <summary>
        /// Gets the list of Polygons enclosed in this MultiPolygon.
        /// </summary>
        [DataMember(Name = "geometries")]
        public List<GeometryObject> Geometries { get; private set; }
    }
}
