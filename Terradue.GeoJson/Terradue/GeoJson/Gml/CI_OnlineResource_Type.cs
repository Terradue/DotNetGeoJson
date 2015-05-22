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
  public class CI_OnlineResource_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType applicationProfileField;
    private CharacterString_PropertyType descriptionField;
    private CI_OnLineFunctionCode_PropertyType functionField;
    private URL_PropertyType linkageField;
    private CharacterString_PropertyType nameField;
    private CharacterString_PropertyType protocolField;

    [XmlElement]
    public URL_PropertyType linkage
    {
      get { return linkageField; }
      set { linkageField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType protocol
    {
      get { return protocolField; }
      set { protocolField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType applicationProfile
    {
      get { return applicationProfileField; }
      set { applicationProfileField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [XmlElement]
    public CI_OnLineFunctionCode_PropertyType function
    {
      get { return functionField; }
      set { functionField = value; }
    }
  }
}