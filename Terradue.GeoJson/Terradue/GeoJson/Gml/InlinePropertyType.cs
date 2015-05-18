namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("abstractInlineProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class InlinePropertyType
  {

    private System.Xml.XmlElement anyField;

    private bool ownsField;

    public InlinePropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any
    {
      get { return anyField; }
      set { anyField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}