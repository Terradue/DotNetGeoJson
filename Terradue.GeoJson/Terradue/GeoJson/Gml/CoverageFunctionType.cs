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
  [XmlRoot("coverageFunction", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CoverageFunctionType
  {
    private object itemField;

    [XmlElement("CoverageMappingRule", typeof (MappingRuleType))]
    [XmlElement("GridFunction", typeof (GridFunctionType))]
    [XmlElement("MappingRule", typeof (StringOrRefType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}