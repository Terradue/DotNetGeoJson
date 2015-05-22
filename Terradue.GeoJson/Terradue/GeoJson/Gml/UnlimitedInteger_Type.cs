using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  public class UnlimitedInteger_Type
  {
    private bool isInfiniteField;
    private bool isInfiniteFieldSpecified;
    private string valueField;

    [XmlAttribute]
    public bool isInfinite
    {
      get { return isInfiniteField; }
      set { isInfiniteField = value; }
    }

    [XmlIgnore]
    public bool isInfiniteSpecified
    {
      get { return isInfiniteFieldSpecified; }
      set { isInfiniteFieldSpecified = value; }
    }

    [XmlText(DataType = "nonNegativeInteger")]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}