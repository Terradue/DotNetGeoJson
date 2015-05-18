namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_Series_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType nameField;

    private CharacterString_PropertyType issueIdentificationField;

    private CharacterString_PropertyType pageField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType issueIdentification
    {
      get { return issueIdentificationField; }
      set { issueIdentificationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType page
    {
      get { return pageField; }
      set { pageField = value; }
    }
  }
}