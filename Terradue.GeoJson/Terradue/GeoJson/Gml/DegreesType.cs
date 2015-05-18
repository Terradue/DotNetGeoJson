namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("degrees", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class DegreesType
  {

    private DegreesTypeDirection directionField;

    private bool directionFieldSpecified;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DegreesTypeDirection direction
    {
      get { return directionField; }
      set { directionField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool directionSpecified
    {
      get { return directionFieldSpecified; }
      set { directionFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}