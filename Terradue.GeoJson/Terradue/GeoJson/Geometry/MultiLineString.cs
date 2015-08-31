//
//  MultiLineString.cs
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
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// Defines the <see cref="http://geojson.org/geojson-spec.html#multilinestring">MultiLineString</see> type.
    /// </summary>
    [DataContract]
    public class MultiLineString : GeometryObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.MultiLineString"/> class.
        /// </summary>
        public MultiLineString() {
            this.LineStrings = new List<LineString>();
            this.Type = GeoJsonObjectType.MultiLineString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiLineString"/> class.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public MultiLineString(List<LineString> lineStrings) {
            this.LineStrings = lineStrings ?? new List<LineString>();
            this.Type = GeoJsonObjectType.MultiLineString;
        }

        /// <summary>
        /// Gets or sets the line strings.
        /// </summary>
        /// <value>The line strings.</value>
        [JsonIgnore]
        public List<LineString> LineStrings { get; set; }

        [JsonProperty(PropertyName = "coordinates")]
        public List<List<List<double>>> Coordinates { 

            get {
                List<List<List<double>>> coordinates = new List<List<List<double>>>();
                foreach (LineString linestring in LineStrings) {
                    coordinates.Add(linestring.Coordinates);
                }
                return coordinates;
            }

            set{ 
                foreach (var list in value) {
                    LineString linestring = new LineString();
                    linestring.Coordinates = list;
                    this.LineStrings.Add(linestring);
                }
            }
        }
    }
}
