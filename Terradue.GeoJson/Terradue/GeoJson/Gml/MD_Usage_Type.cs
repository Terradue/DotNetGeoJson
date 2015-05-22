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
  public class MD_Usage_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType specificUsageField;
    private DateTime_PropertyType usageDateTimeField;
    private CI_ResponsibleParty_PropertyType[] userContactInfoField;
    private CharacterString_PropertyType userDeterminedLimitationsField;

    [XmlElement]
    public CharacterString_PropertyType specificUsage
    {
      get { return specificUsageField; }
      set { specificUsageField = value; }
    }

    [XmlElement]
    public DateTime_PropertyType usageDateTime
    {
      get { return usageDateTimeField; }
      set { usageDateTimeField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType userDeterminedLimitations
    {
      get { return userDeterminedLimitationsField; }
      set { userDeterminedLimitationsField = value; }
    }

    [XmlElement("userContactInfo")]
    public CI_ResponsibleParty_PropertyType[] userContactInfo
    {
      get { return userContactInfoField; }
      set { userContactInfoField = value; }
    }
  }
}