using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  public enum SequenceRuleEnumeration
  {
    /// <remarks />
    Linear,

    /// <remarks />
    Boustrophedonic,

    /// <remarks />
    [XmlEnum("Cantor-diagonal")] Cantordiagonal,

    /// <remarks />
    Spiral,

    /// <remarks />
    Morton,

    /// <remarks />
    Hilbert
  }
}