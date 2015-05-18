namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class PT_LocaleContainer_Type
  {

    private CharacterString_PropertyType descriptionField;

    private PT_Locale_PropertyType localeField;

    private CI_Date_PropertyType[] dateField;

    private CI_ResponsibleParty_PropertyType[] responsiblePartyField;

    private LocalisedCharacterString_PropertyType[] localisedStringField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType description
    {
      get { return descriptionField; }
      set { descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public PT_Locale_PropertyType locale
    {
      get { return localeField; }
      set { localeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("date")]
    public CI_Date_PropertyType[] date
    {
      get { return dateField; }
      set { dateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("responsibleParty")]
    public CI_ResponsibleParty_PropertyType[] responsibleParty
    {
      get { return responsiblePartyField; }
      set { responsiblePartyField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("localisedString")]
    public LocalisedCharacterString_PropertyType[] localisedString
    {
      get { return localisedStringField; }
      set { localisedStringField = value; }
    }
  }
}