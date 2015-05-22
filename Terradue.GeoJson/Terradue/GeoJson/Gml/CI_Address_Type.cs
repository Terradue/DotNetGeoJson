using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class CI_Address_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType administrativeAreaField;
    private CharacterString_PropertyType cityField;
    private CharacterString_PropertyType countryField;
    private CharacterString_PropertyType[] deliveryPointField;
    private CharacterString_PropertyType[] electronicMailAddressField;
    private CharacterString_PropertyType postalCodeField;

    [XmlElement("deliveryPoint")]
    public CharacterString_PropertyType[] deliveryPoint
    {
      get { return deliveryPointField; }
      set { deliveryPointField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType city
    {
      get { return cityField; }
      set { cityField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType administrativeArea
    {
      get { return administrativeAreaField; }
      set { administrativeAreaField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType postalCode
    {
      get { return postalCodeField; }
      set { postalCodeField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType country
    {
      get { return countryField; }
      set { countryField = value; }
    }

    [XmlElement("electronicMailAddress")]
    public CharacterString_PropertyType[] electronicMailAddress
    {
      get { return electronicMailAddressField; }
      set { electronicMailAddressField = value; }
    }
  }
}