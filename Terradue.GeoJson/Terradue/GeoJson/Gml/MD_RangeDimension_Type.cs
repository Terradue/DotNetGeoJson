namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_Band_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_RangeDimension_Type : AbstractObject_Type
  {

    private MemberName_PropertyType sequenceIdentifierField;

    private CharacterString_PropertyType descriptorField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MemberName_PropertyType sequenceIdentifier
    {
      get { return sequenceIdentifierField; }
      set { sequenceIdentifierField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType descriptor
    {
      get { return descriptorField; }
      set { descriptorField = value; }
    }
  }
}