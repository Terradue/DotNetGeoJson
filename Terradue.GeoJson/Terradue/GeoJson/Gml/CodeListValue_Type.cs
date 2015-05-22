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
  public class CodeListValue_Type
  {
    private string codeListField;
    private string codeListValueField;
    private string codeSpaceField;
    private string valueField;

    [XmlAttribute(DataType = "anyURI")]
    public string codeList
    {
      get { return codeListField; }
      set { codeListField = value; }
    }

    [XmlAttribute(DataType = "anyURI")]
    public string codeListValue
    {
      get { return codeListValueField; }
      set { codeListValueField = value; }
    }

    [XmlAttribute(DataType = "anyURI")]
    public string codeSpace
    {
      get { return codeSpaceField; }
      set { codeSpaceField = value; }
    }

    [XmlText]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}