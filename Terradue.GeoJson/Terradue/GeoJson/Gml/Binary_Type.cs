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
  public class Binary_Type
  {
    private string srcField;
    private string valueField;

    [XmlAttribute(DataType = "anyURI")]
    public string src
    {
      get { return srcField; }
      set { srcField = value; }
    }

    [XmlText]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}