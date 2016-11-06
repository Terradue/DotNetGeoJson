//
//  ProjectedPosition.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue
//
//  Adapted from GeoJSON.Net / https://github.com/jbattermann/GeoJSON.Net
//      Copyright (c) Jörg Battermann 2011

using System;
using System.Globalization;

namespace Terradue.GeoJson.Geometry
{
  /// <summary>
  ///   Defines the Projected Position type a.k.a.
  ///   <see cref="http://geojson.org/geojson-spec.html#positions">Projected Coordinate Reference System</see>.
  /// </summary>
  public class ProjectedPosition : Position
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="ProjectedPosition" /> class.
    /// </summary>
    /// <param name="easting">The easting.</param>
    /// <param name="northing">The northing.</param>
    /// <param name="altitude">The altitude in m(eter).</param>
    public ProjectedPosition(double easting, double northing, double? altitude)
      : this()
    {
      throw new NotImplementedException("Someone needs to do this...");
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="ProjectedPosition" /> class.
    /// </summary>
    /// <param name="easting">The easting, e.g. '38.889722'.</param>
    /// <param name="northing">The northing, e.g. '-77.008889'.</param>
    /// <param name="altitude">The altitude in m(eter).</param>
    public ProjectedPosition(string easting, string northing, string altitude)
      : this()
    {
      throw new NotImplementedException("Someone needs to do this...");
    }

    /// <summary>
    ///   Prevents a default instance of the <see cref="ProjectedPosition" /> class from being created.
    /// </summary>
    private ProjectedPosition()
    {
      throw new NotImplementedException("Someone needs to do this...");
    }

    /// <summary>
    ///   Gets the easting.
    /// </summary>
    /// <value>The easting.</value>
    public double Easting
    {
      get { throw new NotImplementedException("Someone needs to do this..."); }
    }

    /// <summary>
    ///   Gets the northing.
    /// </summary>
    /// <value>The northing.</value>
    public double Northing
    {
      get { throw new NotImplementedException("Someone needs to do this..."); }
    }

    /// <summary>
    ///   Gets the altitude.
    /// </summary>
    public double? Altitude
    {
      get { throw new NotImplementedException("Someone needs to do this..."); }
    }

    /// <summary>
    ///   Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    ///   A <see cref="System.String" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
      return Altitude == null
        ? string.Format(CultureInfo.InvariantCulture, "Easting: {0}, Northing: {1}", Easting, Northing)
        : string.Format(CultureInfo.InvariantCulture, "Easting: {0}, Northing: {1}, Altitude: {2}", Easting, Northing,
          Altitude);
    }

    public override bool Equals(IPosition pos)
    {
      if (pos.GetType() != typeof(GeographicPosition)) return false;
      var position = (ProjectedPosition) pos;
      if ((position.Northing != Easting) || (position.Northing != Northing))
        return false;
      if ((position.Altitude != null) && (Altitude != null)) return position.Altitude.Equals(Altitude);

      return true;
    }
  }
}