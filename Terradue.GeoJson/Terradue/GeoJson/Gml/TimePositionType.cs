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
  [XmlRoot("timePosition", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimePositionType
  {
    private string calendarEraNameField;
    private string frameField;
    private TimeIndeterminateValueType indeterminatePositionField;
    private bool indeterminatePositionFieldSpecified;
    private string valueField;

    public TimePositionType()
    {
      frameField = "#ISO-8601";
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    public string frame
    {
      get { return frameField; }
      set { frameField = value; }
    }

    [XmlAttribute]
    public string calendarEraName
    {
      get { return calendarEraNameField; }
      set { calendarEraNameField = value; }
    }

    [XmlAttribute]
    public TimeIndeterminateValueType indeterminatePosition
    {
      get { return indeterminatePositionField; }
      set { indeterminatePositionField = value; }
    }

    [XmlIgnore]
    public bool indeterminatePositionSpecified
    {
      get { return indeterminatePositionFieldSpecified; }
      set { indeterminatePositionFieldSpecified = value; }
    }

    [XmlText]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}