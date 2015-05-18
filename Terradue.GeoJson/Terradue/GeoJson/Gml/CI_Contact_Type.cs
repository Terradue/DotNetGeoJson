namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_Contact_Type : AbstractObject_Type
  {

    private CI_Telephone_PropertyType phoneField;

    private CI_Address_PropertyType addressField;

    private CI_OnlineResource_PropertyType onlineResourceField;

    private CharacterString_PropertyType hoursOfServiceField;

    private CharacterString_PropertyType contactInstructionsField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Telephone_PropertyType phone
    {
      get { return phoneField; }
      set { phoneField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Address_PropertyType address
    {
      get { return addressField; }
      set { addressField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_OnlineResource_PropertyType onlineResource
    {
      get { return onlineResourceField; }
      set { onlineResourceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType hoursOfService
    {
      get { return hoursOfServiceField; }
      set { hoursOfServiceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType contactInstructions
    {
      get { return contactInstructionsField; }
      set { contactInstructionsField = value; }
    }
  }
}