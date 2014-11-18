//
//  LineString.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

namespace Terradue.GeoJson.Geometry {
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

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

            this.Positions = new List<IPosition>(positions);
            this.Type = GeoJsonObjectType.LineString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.LineString"/> class.
        /// </summary>
        internal LineString() {
            this.Positions = new List<IPosition>();
            this.Type = GeoJsonObjectType.LineString;
        }

        /// <summary>
        /// Gets or sets the positions.
        /// </summary>
        /// <value>The positions.</value>
        public List<IPosition> Positions { get; set; }

        /// <summary>
        /// Determines whether this LineString is a <see cref="http://geojson.org/geojson-spec.html#linestring">LinearRing</see>.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if it is a linear ring; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLinearRing() {
            return this.Positions.Count >= 4 && this.IsClosed();
        }

        /// <summary>
        /// Determines whether this instance has its first and last coordinate at the same position and thereby is closed.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is closed; otherwise, <c>false</c>.
        /// </returns>
        public bool IsClosed() {
            return this.Positions[0].Equals(this.Positions[this.Positions.Count - 1]);
        }

        /// <summary>
        /// Gets the coordinates
        /// </summary>
        [DataMember(Name = "coordinates")]
        public List<List<double>> Coordinates { 
			
            get {
                List<List<double>> coordinates = new List<List<double>>();
                foreach (GeographicPosition position in Positions) {
                    List<double> xyz = new List<double>();
                    xyz.Add(position.Longitude);
                    xyz.Add(position.Latitude);
                    if (position.Coordinates[2] != null) xyz.Add(position.Altitude);
                    coordinates.Add(xyz);
                }
                return coordinates;
            }
			
            set {
                foreach (var list in value) {
                    double[] positions = list.ToArray();
                    GeographicPosition geographicPosition;
                    if (positions.Length == 2) {
                        geographicPosition = new GeographicPosition(positions[1], positions[0]);
                    } else if (positions.Length == 3) {
                        geographicPosition = new GeographicPosition(positions[1], positions[0], positions[2]);
                    } else {
                        throw new InvalidFormatException("a geographic position must have at least 2 coordinates");
                    }
                    this.Positions.Add(geographicPosition);
                }
            } 
        }
    }
}
 