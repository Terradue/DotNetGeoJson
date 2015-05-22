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
  public class CI_Contact_Type : AbstractObject_Type
  {
    private CI_Address_PropertyType addressField;
    private CharacterString_PropertyType contactInstructionsField;
    private CharacterString_PropertyType hoursOfServiceField;
    private CI_OnlineResource_PropertyType onlineResourceField;
    private CI_Telephone_PropertyType phoneField;

    [XmlElement]
    public CI_Telephone_PropertyType phone
    {
      get { return phoneField; }
      set { phoneField = value; }
    }

    [XmlElement]
    public CI_Address_PropertyType address
    {
      get { return addressField; }
      set { addressField = value; }
    }

    [XmlElement]
    public CI_OnlineResource_PropertyType onlineResource
    {
      get { return onlineResourceField; }
      set { onlineResourceField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType hoursOfService
    {
      get { return hoursOfServiceField; }
      set { hoursOfServiceField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType contactInstructions
    {
      get { return contactInstructionsField; }
      set { contactInstructionsField = value; }
    }
  }
}