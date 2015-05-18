namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_OnlineResource_Type : AbstractObject_Type
  {

    private URL_PropertyType linkageField;

    private CharacterString_PropertyType protocolField;

    private CharacterString_PropertyType applicationProfileField;

    private CharacterString_PropertyType nameField;

    private CharacterString_PropertyType descriptionField;

    private CI_OnLineFunctionCode_PropertyType functionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public URL_PropertyType linkage
    {
      get { return linkageField; }
      set { linkageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType protocol
    {
      get { return protocolField; }
      set { protocolField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType applicationProfile
    {
      get { return applicationProfileField; }
      set { applicationProfileField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType name
    {
      get { return nameField; }
      set { nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_OnLineFunctionCode_PropertyType function
    {
      get { return functionField; }
      set { functionField = value; }
    }
  }
}