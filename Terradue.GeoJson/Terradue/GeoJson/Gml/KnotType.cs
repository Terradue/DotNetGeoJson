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
  public class KnotType
  {
    private string multiplicityField;
    private double valueField;
    private double weightField;

    [XmlElement]
    public double value
    {
      get { return valueField; }
      set { valueField = value; }
    }

    [XmlElement(DataType = "nonNegativeInteger")]
    public string multiplicity
    {
      get { return multiplicityField; }
      set { multiplicityField = value; }
    }

    [XmlElement]
    public double weight
    {
      get { return weightField; }
      set { weightField = value; }
    }
  }
}