using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractContinuousCoverage", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractContinuousCoverageType : AbstractCoverageType
  {
    private CoverageFunctionType coverageFunctionField;

    [XmlElement]
    public CoverageFunctionType coverageFunction
    {
      get { return coverageFunctionField; }
      set { coverageFunctionField = value; }
    }
  }
}