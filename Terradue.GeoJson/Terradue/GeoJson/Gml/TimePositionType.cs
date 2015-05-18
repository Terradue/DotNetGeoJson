namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("timePosition", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimePositionType
  {

    private string frameField;

    private string calendarEraNameField;

    private TimeIndeterminateValueType indeterminatePositionField;

    private bool indeterminatePositionFieldSpecified;

    private string valueField;

    public TimePositionType()
    {
      frameField = "#ISO-8601";
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
    public string frame
    {
      get { return frameField; }
      set { frameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string calendarEraName
    {
      get { return calendarEraNameField; }
      set { calendarEraNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TimeIndeterminateValueType indeterminatePosition
    {
      get { return indeterminatePositionField; }
      set { indeterminatePositionField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool indeterminatePositionSpecified
    {
      get { return indeterminatePositionFieldSpecified; }
      set { indeterminatePositionFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}