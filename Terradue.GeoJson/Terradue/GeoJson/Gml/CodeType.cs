using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (CodeWithAuthorityType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("name", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class CodeType
  {
    private string codeSpaceField;
    private string valueField;

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