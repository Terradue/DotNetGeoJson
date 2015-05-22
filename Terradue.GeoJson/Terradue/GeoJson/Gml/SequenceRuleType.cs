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
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class SequenceRuleType
  {
    private string[] axisOrderField;
    private IncrementOrder orderField;
    private bool orderFieldSpecified;
    private SequenceRuleEnumeration valueField;

    [XmlAttribute]
    public IncrementOrder order
    {
      get { return orderField; }
      set { orderField = value; }
    }

    [XmlIgnore]
    public bool orderSpecified
    {
      get { return orderFieldSpecified; }
      set { orderFieldSpecified = value; }
    }

    [XmlAttribute]
    public string[] axisOrder
    {
      get { return axisOrderField; }
      set { axisOrderField = value; }
    }

    [XmlText]
    public SequenceRuleEnumeration Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}