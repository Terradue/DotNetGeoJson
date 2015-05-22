using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  public enum SurfaceInterpolationType
  {
    /// <remarks />
    none,

    /// <remarks />
    planar,

    /// <remarks />
    spherical,

    /// <remarks />
    elliptical,

    /// <remarks />
    conic,

    /// <remarks />
    tin,

    /// <remarks />
    parametricCurve,

    /// <remarks />
    polynomialSpline,

    /// <remarks />
    rationalSpline,

    /// <remarks />
    triangulatedSpline
  }
}