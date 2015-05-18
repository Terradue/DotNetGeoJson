namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class MemberName_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType aNameField;

    private TypeName_PropertyType attributeTypeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType aName
    {
      get { return aNameField; }
      set { aNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TypeName_PropertyType attributeType
    {
      get { return attributeTypeField; }
      set { attributeTypeField = value; }
    }
  }
}