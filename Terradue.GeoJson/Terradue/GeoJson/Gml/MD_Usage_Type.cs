namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Usage_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType specificUsageField;

    private DateTime_PropertyType usageDateTimeField;

    private CharacterString_PropertyType userDeterminedLimitationsField;

    private CI_ResponsibleParty_PropertyType[] userContactInfoField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType specificUsage
    {
      get { return specificUsageField; }
      set { specificUsageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public DateTime_PropertyType usageDateTime
    {
      get { return usageDateTimeField; }
      set { usageDateTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType userDeterminedLimitations
    {
      get { return userDeterminedLimitationsField; }
      set { userDeterminedLimitationsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("userContactInfo")]
    public CI_ResponsibleParty_PropertyType[] userContactInfo
    {
      get { return userContactInfoField; }
      set { userContactInfoField = value; }
    }
  }
}