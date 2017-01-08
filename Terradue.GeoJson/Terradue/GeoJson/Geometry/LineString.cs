﻿//
//  LineString.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Terradue.GeoJson.Geometry {
  /// <summary>
    ///   Defines the <see cref="http://geojson.org/geojson-spec.html#linestring">LineString</see> type.
    /// </summary>
    [DataContract]
    public class LineString : GeometryObject {

        /// <summary>
        /// Initializes a new instance of the <see cref="LineString"/> class.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public LineString(List<IPosition> positions = null) {
            if (positions == null) {
                throw new ArgumentNullException("coordinates");
            }

            if (positions.Count < 2) {
                throw new ArgumentOutOfRangeException("coordinates", "According to the GeoJSON v1.0 spec a LineString must have at least two or more positions.");
            }

            Positions = new List<IPosition>(positions);
            Type = GeoJsonObjectType.LineString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.LineString"/> class.
        /// </summary>
        internal LineString() {
            Positions = new List<IPosition>();
            Type = GeoJsonObjectType.LineString;
        }

        /// <summary>
        /// Gets or sets the positions.
        /// </summary>
        /// <value>The positions.</value>
        [JsonIgnore]
        public List<IPosition> Positions { get; set; }

        /// <summary>
        /// Determines whether this LineString is a <see cref="http://geojson.org/geojson-spec.html#linestring">LinearRing</see>.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if it is a linear ring; otherwise, <c>false</c>.
        /// </returns>
        public bool IslInearRing(){
            return Positions.Count >= 4 && IsClosed();
        }

        /// <summary>
        /// Determines whether this instance has its first and last coordinate at the same position and thereby is closed.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is closed; otherwise, <c>false</c>.
        /// </returns>
        public bool IsClosed() {
            return Positions[0].Equals(Positions[Positions.Count - 1]);
        }

        /// <summary>
        /// Gets the coordinates
        /// </summary>
        [JsonProperty(PropertyName = "coordinates")]
        public List<List<double>> Coordinates { 
            get {
                var coordinates = new List<List<double>>();
                foreach (GeographicPosition position in Positions) {
                    var xyz = new List<double>();
                    xyz.Add(position.Longitude);
                    xyz.Add(position.Latitude);
                    if (position.Coordinates[2] != null) xyz.Add(position.Altitude.GetValueOrDefault());
                    coordinates.Add(xyz);
                }
                return coordinates;
            }
			
            set {
                foreach (var list in value) {
                    var positions = list.ToArray();
                    GeographicPosition geographicPosition;
                    if (positions.Length == 2) {
                        geographicPosition = new GeographicPosition(positions[1], positions[0]);
                    } else if (positions.Length == 3) {
                        geographicPosition = new GeographicPosition(positions[1], positions[0], positions[2]);
                    } else {
                        throw new InvalidFormatException("a geographic position must have at least 2 coordinates");
                    }
                    Positions.Add(geographicPosition);
                }
            } 
        }
    }
}
 