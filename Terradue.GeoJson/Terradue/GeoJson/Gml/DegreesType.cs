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
  [XmlRoot("degrees", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class DegreesType
  {
    private DegreesTypeDirection directionField;
    private bool directionFieldSpecified;
    private string valueField;

    [XmlAttribute]
    public DegreesTypeDirection direction
    {
      get { return directionField; }
      set { directionField = value; }
    }

    [XmlIgnore]
    public bool directionSpecified
    {
      get { return directionFieldSpecified; }
      set { directionFieldSpecified = value; }
    }

    [XmlText(DataType = "nonNegativeInteger")]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}