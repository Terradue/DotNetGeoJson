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
  public class CI_ResponsibleParty_Type : AbstractObject_Type
  {
    private CI_Contact_PropertyType contactInfoField;
    private CharacterString_PropertyType individualNameField;
    private CharacterString_PropertyType organisationNameField;
    private CharacterString_PropertyType positionNameField;
    private CI_RoleCode_PropertyType roleField;

    [XmlElement]
    public CharacterString_PropertyType individualName
    {
      get { return individualNameField; }
      set { individualNameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType organisationName
    {
      get { return organisationNameField; }
      set { organisationNameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType positionName
    {
      get { return positionNameField; }
      set { positionNameField = value; }
    }

    [XmlElement]
    public CI_Contact_PropertyType contactInfo
    {
      get { return contactInfoField; }
      set { contactInfoField = value; }
    }

    [XmlElement]
    public CI_RoleCode_PropertyType role
    {
      get { return roleField; }
      set { roleField = value; }
    }
  }
}