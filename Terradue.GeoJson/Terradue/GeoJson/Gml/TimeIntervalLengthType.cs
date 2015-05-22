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
  [XmlRoot("timeInterval", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeIntervalLengthType
  {
    private string factorField;
    private string radixField;
    private string unitField;
    private decimal valueField;

    [XmlAttribute]
    public string unit
    {
      get { return unitField; }
      set { unitField = value; }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    public string radix
    {
      get { return radixField; }
      set { radixField = value; }
    }

    [XmlAttribute(DataType = "integer")]
    public string factor
    {
      get { return factorField; }
      set { factorField = value; }
    }

    [XmlText]
    public decimal Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}