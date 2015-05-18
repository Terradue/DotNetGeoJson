namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class LocalisedCharacterString_PropertyType : ObjectReference_PropertyType
  {

    private LocalisedCharacterString_Type localisedCharacterStringField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public LocalisedCharacterString_Type LocalisedCharacterString
    {
      get { return localisedCharacterStringField; }
      set { localisedCharacterStringField = value; }
    }
  }
}