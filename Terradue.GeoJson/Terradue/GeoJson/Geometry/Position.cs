//
//  Position.cs
//
//  Author:
//       Emmanuel Mathot <emmanuel.mathot@terradue.com>
//
//  Copyright (c) 2014 Terradue

namespace Terradue.GeoJson.Geometry
{
  public abstract class Position : IPosition
  {
    public abstract bool Equals(IPosition pos);
  }
}