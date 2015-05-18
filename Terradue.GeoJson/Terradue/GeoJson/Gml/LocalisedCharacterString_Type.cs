namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class LocalisedCharacterString_Type
  {

    private string idField;

    private string localeField;

    private string valueField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string id
    {
      get { return idField; }
      set { idField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string locale
    {
      get { return localeField; }
      set { localeField = value; }
    }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}