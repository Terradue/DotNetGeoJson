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
  public class PT_LocaleContainer_Type
  {
    private CI_Date_PropertyType[] dateField;
    private CharacterString_PropertyType descriptionField;
    private PT_Locale_PropertyType localeField;
    private LocalisedCharacterString_PropertyType[] localisedStringField;
    private CI_ResponsibleParty_PropertyType[] responsiblePartyField;

    [XmlElement]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [XmlElement]
    public PT_Locale_PropertyType locale
    {
      get { return localeField; }
      set { localeField = value; }
    }

    [XmlElement("date")]
    public CI_Date_PropertyType[] date
    {
      get { return dateField; }
      set { dateField = value; }
    }

    [XmlElement("responsibleParty")]
    public CI_ResponsibleParty_PropertyType[] responsibleParty
    {
      get { return responsiblePartyField; }
      set { responsiblePartyField = value; }
    }

    [XmlElement("localisedString")]
    public LocalisedCharacterString_PropertyType[] localisedString
    {
      get { return localisedStringField; }
      set { localisedStringField = value; }
    }
  }
}