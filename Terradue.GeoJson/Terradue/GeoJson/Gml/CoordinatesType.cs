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
  [XmlRoot("tupleList", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CoordinatesType
  {
    private string csField;
    private string decimalField;
    private string tsField;
    private string valueField;

    public CoordinatesType()
    {
      decimalField = ".";
      csField = ",";
      tsField = " ";
    }

    [XmlAttribute]
    [DefaultValue(".")]
    public string @decimal
    {
      get { return decimalField; }
      set { decimalField = value; }
    }

    [XmlAttribute]
    [DefaultValue(",")]
    public string cs
    {
      get { return csField; }
      set { csField = value; }
    }

    [XmlAttribute]
    [DefaultValue(" ")]
    public string ts
    {
      get { return tsField; }
      set { tsField = value; }
    }

    [XmlText]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}