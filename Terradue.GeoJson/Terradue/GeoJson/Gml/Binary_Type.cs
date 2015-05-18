namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class Binary_Type
  {

    private string srcField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string src
    {
      get { return srcField; }
      set { srcField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}