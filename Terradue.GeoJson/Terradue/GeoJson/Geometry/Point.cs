//
//  MultiPolygon.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011
using Newtonsoft.Json;

namespace Terradue.GeoJson.Geometry {
    using System;
    using System.Collections.Generic;

  /// <summary>
    /// In geography, a point refers to a Position on a map, expressed in latitude and longitude.
    /// </summary>
    /// <seealso cref="http://geojson.org/geojson-spec.html#point"/>
    public class Point : GeometryObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="coordinates">The Position.</param>
        public Point(IPosition coordinates) {
            if (coordinates == null) {
                throw new ArgumentNullException("coordinates");
            }

            Position = coordinates;
            Type = GeoJsonObjectType.Point;
        }

        internal Point(){
            Position = null;
            Type = GeoJsonObjectType.Point;
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        [JsonIgnore]
        public IPosition Position { get; set; }

        /// <summary>
        /// Gets the Coordinate(s).
        /// </summary>
        /// <value>The Coordinates.</value>
        //        [JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
        //        [JsonConverter(typeof(PositionConverter))]
        [JsonProperty(PropertyName = "coordinates")]
        public List<double> Coordinates {
            get {
                List<double> coordinates = new List<double>();
                coordinates.Add((double)((GeographicPosition)Position).Coordinates[1]);
                coordinates.Add((double)((GeographicPosition)Position).Coordinates[0]);
                return coordinates;
            }

            set{
                Position = new GeographicPosition(value[1], value[0]);
            }
        }
    }
}
