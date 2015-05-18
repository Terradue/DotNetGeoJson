namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_Address_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType[] deliveryPointField;

    private CharacterString_PropertyType cityField;

    private CharacterString_PropertyType administrativeAreaField;

    private CharacterString_PropertyType postalCodeField;

    private CharacterString_PropertyType countryField;

    private CharacterString_PropertyType[] electronicMailAddressField;

    [System.Xml.Serialization.XmlElementAttribute("deliveryPoint")]
    public CharacterString_PropertyType[] deliveryPoint
    {
      get { return deliveryPointField; }
      set { deliveryPointField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType city
    {
      get { return cityField; }
      set { cityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType administrativeArea
    {
      get { return administrativeAreaField; }
      set { administrativeAreaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType postalCode
    {
      get { return postalCodeField; }
      set { postalCodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType country
    {
      get { return countryField; }
      set { countryField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("electronicMailAddress")]
    public CharacterString_PropertyType[] electronicMailAddress
    {
      get { return electronicMailAddressField; }
      set { electronicMailAddressField = value; }
    }
  }
}