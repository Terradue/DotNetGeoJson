using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class LocalisedCharacterString_Type
  {
    private string idField;
    private string localeField;
    private string valueField;

    [XmlAttribute(DataType = "ID")]
    public string id
    {
      get { return idField; }
      set { idField = value; }
    }

    [XmlAttribute(DataType = "anyURI")]
    public string locale
    {
      get { return localeField; }
      set { localeField = value; }
    }

    [XmlText]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}