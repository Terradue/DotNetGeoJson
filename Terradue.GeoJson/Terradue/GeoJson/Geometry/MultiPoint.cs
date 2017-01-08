//
//  MultiPoint.cs
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

  /// <summary>
    /// Contains an array of <see cref="Point"/>s.
    /// </summary>
    /// <seealso cref="http://geojson.org/geojson-spec.html#multipoint"/>
    [DataContract]
    public class MultiPoint : GeometryObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPoint"/> class.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public MultiPoint(List<IPosition> points = null) {
            Points = new List<Point>();
            foreach (var ipos in points) Points.Add(new Point(ipos));
            Type = GeoJsonObjectType.MultiPoint;
        }

        internal MultiPoint() {
            Points = new List<Point>();

            Type = GeoJsonObjectType.MultiPoint;
        }

        /// <summary>
        /// Gets or sets the points.
        /// </summary>
        /// <value>The points.</value>
        [JsonIgnore]
        public List<Point> Points { get; set; }

        /// <summary>
        /// Gets the Coordinates.
        /// </summary>
        /// <value>The Coordinates.</value>
        //[JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
        [JsonProperty(PropertyName = "coordinates")]
        public List<List<double>> Coordinates { 

            get {
                var coordinates = new List<List<double>>();
                foreach (var ipos in Points) {
                    coordinates.Add(ipos.Coordinates);
                }
                return coordinates;
            }

            set{ 
                foreach (var list in value) {
                    var point = new Point();
                    point.Coordinates = list;
                    Points.Add(point);
                }
            }
        }
    }
}
