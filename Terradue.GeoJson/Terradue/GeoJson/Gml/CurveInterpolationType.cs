using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  public enum CurveInterpolationType
  {
    /// <remarks />
    linear,

    /// <remarks />
    geodesic,

    /// <remarks />
    circularArc3Points,

    /// <remarks />
    circularArc2PointWithBulge,

    /// <remarks />
    circularArcCenterPointWithRadius,

    /// <remarks />
    elliptical,

    /// <remarks />
    clothoid,

    /// <remarks />
    conic,

    /// <remarks />
    polynomialSpline,

    /// <remarks />
    cubicSpline,

    /// <remarks />
    rationalSpline
  }
}