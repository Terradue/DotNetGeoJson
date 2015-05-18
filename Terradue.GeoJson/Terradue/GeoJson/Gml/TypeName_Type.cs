namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class TypeName_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType aNameField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType aName
    {
      get { return aNameField; }
      set { aNameField = value; }
    }
  }
}