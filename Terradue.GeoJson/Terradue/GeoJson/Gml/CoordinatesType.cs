namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("tupleList", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CoordinatesType
  {

    private string decimalField;

    private string csField;

    private string tsField;

    private string valueField;

    public CoordinatesType()
    {
      decimalField = ".";
      csField = ",";
      tsField = " ";
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(".")]
    public string @decimal
    {
      get { return decimalField; }
      set { decimalField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(",")]
    public string cs
    {
      get { return csField; }
      set { csField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(" ")]
    public string ts
    {
      get { return tsField; }
      set { tsField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}