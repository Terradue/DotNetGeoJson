namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_ResponsibleParty_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType individualNameField;

    private CharacterString_PropertyType organisationNameField;

    private CharacterString_PropertyType positionNameField;

    private CI_Contact_PropertyType contactInfoField;

    private CI_RoleCode_PropertyType roleField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType individualName
    {
      get { return individualNameField; }
      set { individualNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType organisationName
    {
      get { return organisationNameField; }
      set { organisationNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType positionName
    {
      get { return positionNameField; }
      set { positionNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Contact_PropertyType contactInfo
    {
      get { return contactInfoField; }
      set { contactInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_RoleCode_PropertyType role
    {
      get { return roleField; }
      set { roleField = value; }
    }
  }
}