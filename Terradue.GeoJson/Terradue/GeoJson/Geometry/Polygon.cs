//
//  Polygon.cs
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

namespace Terradue.GeoJson.Geometry
{
  /// <summary>
  ///   Defines the <see cref="http://geojson.org/geojson-spec.html#polygon">Polygon</see> type.
  ///   Coordinates of a Polygon are a list of <see cref="http://geojson.org/geojson-spec.html#linestring">linear rings</see>
  ///   coordinate arrays. The first element in the array represents the exterior ring. Any subsequent elements
  ///   represent interior rings (or holes).
  /// </summary>
  /// <seealso cref="http://geojson.org/geojson-spec.html#polygon" />
  [DataContract]
  public class Polygon : GeometryObject
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="Terradue.GeoJson.Geometry.Polygon" /> class.
    /// </summary>
    public Polygon()
    {
      LineStrings = new List<LineString>();
      Type = GeoJsonObjectType.Polygon;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="Polygon" /> class.
    /// </summary>
    /// <param name="linearRings">
    ///   The <see cref="http://geojson.org/geojson-spec.html#linestring">linear rings</see> with the first element
    ///   in the array representing the exterior ring. Any subsequent elements represent interior rings (or holes).
    /// </param>
    public Polygon(List<LineString> linearRings = null)
    {
      // TODO control linear ring
      /*if (linearRings.Any(linearRing => !linearRing.IsLinearRing()))
            {
                throw new ArgumentOutOfRangeException("linearRings", "All elements must be closed LineStrings with 4 or more positions (see GeoJSON spec at 'http://geojson.org/geojson-spec.html#linestring').");
            }*/

      LineStrings = linearRings ?? new List<LineString>();
      Type = GeoJsonObjectType.Polygon;
    }

    /// <summary>
    ///   Gets the list of points outlining this Polygon.
    /// </summary>
    public List<LineString> LineStrings { get; set; }

    /// <summary>
    ///   Gets the coordinates
    /// </summary>
    [DataMember(Name = "coordinates")]
    public List<List<List<double>>> Coordinates
    {
      get
      {
        var coordinates = new List<List<List<double>>>();
        foreach (var linestring in LineStrings)
        {
          coordinates.Add(linestring.Coordinates);
        }
        return coordinates;
      }

      set
      {
        foreach (var list in value)
        {
          var linestring = new LineString {Coordinates = list};
          LineStrings.Add(linestring);
        }
      }
    }
  }
}