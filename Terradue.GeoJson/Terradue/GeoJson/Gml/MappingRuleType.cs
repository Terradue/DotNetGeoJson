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
  [XmlRoot("CoverageMappingRule", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MappingRuleType
  {
    private object itemField;

    [XmlElement("ruleDefinition", typeof (string))]
    [XmlElement("ruleReference", typeof (ReferenceType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}