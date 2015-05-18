namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class PT_FreeText_Type : AbstractObject_Type
  {

    private LocalisedCharacterString_PropertyType[] textGroupField;

    [System.Xml.Serialization.XmlElementAttribute("textGroup")]
    public LocalisedCharacterString_PropertyType[] textGroup
    {
      get { return textGroupField; }
      set { textGroupField = value; }
    }
  }
}