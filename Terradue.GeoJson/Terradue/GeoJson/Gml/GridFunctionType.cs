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
  [XmlRoot("GridFunction", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GridFunctionType
  {
    private SequenceRuleType sequenceRuleField;
    private string startPointField;

    [XmlElement]
    public SequenceRuleType sequenceRule
    {
      get { return sequenceRuleField; }
      set { sequenceRuleField = value; }
    }

    [XmlElement]
    public string startPoint
    {
      get { return startPointField; }
      set { startPointField = value; }
    }
  }
}