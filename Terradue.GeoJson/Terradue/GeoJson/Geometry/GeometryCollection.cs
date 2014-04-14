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

namespace Terradue.GeoJson.Geometry {
    using System.Collections.Generic;
    using System.Runtime.Serialization;

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
            this.Geometries = geometries ?? new List<GeometryObject>();
            this.Type = GeoJsonObjectType.GeometryCollection;
        }

        /// <summary>
        /// Gets the list of Polygons enclosed in this MultiPolygon.
        /// </summary>
        [DataMember(Name = "geometries")]
        public List<GeometryObject> Geometries { get; private set; }
    }
}
