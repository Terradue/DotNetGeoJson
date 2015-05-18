namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class CI_Citation_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType titleField;

    private CharacterString_PropertyType[] alternateTitleField;

    private CI_Date_PropertyType[] dateField;

    private CharacterString_PropertyType editionField;

    private Date_PropertyType editionDateField;

    private MD_Identifier_PropertyType[] identifierField;

    private CI_ResponsibleParty_PropertyType[] citedResponsiblePartyField;

    private CI_PresentationFormCode_PropertyType[] presentationFormField;

    private CI_Series_PropertyType seriesField;

    private CharacterString_PropertyType otherCitationDetailsField;

    private CharacterString_PropertyType collectiveTitleField;

    private CharacterString_PropertyType iSBNField;

    private CharacterString_PropertyType iSSNField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType title
    {
      get { return titleField; }
      set { titleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("alternateTitle")]
    public CharacterString_PropertyType[] alternateTitle
    {
      get { return alternateTitleField; }
      set { alternateTitleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("date")]
    public CI_Date_PropertyType[] date
    {
      get { return dateField; }
      set { dateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType edition
    {
      get { return editionField; }
      set { editionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Date_PropertyType editionDate
    {
      get { return editionDateField; }
      set { editionDateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("identifier")]
    public MD_Identifier_PropertyType[] identifier
    {
      get { return identifierField; }
      set { identifierField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("citedResponsibleParty")]
    public CI_ResponsibleParty_PropertyType[] citedResponsibleParty
    {
      get { return citedResponsiblePartyField; }
      set { citedResponsiblePartyField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("presentationForm")]
    public CI_PresentationFormCode_PropertyType[] presentationForm
    {
      get { return presentationFormField; }
      set { presentationFormField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Series_PropertyType series
    {
      get { return seriesField; }
      set { seriesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType otherCitationDetails
    {
      get { return otherCitationDetailsField; }
      set { otherCitationDetailsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType collectiveTitle
    {
      get { return collectiveTitleField; }
      set { collectiveTitleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType ISBN
    {
      get { return iSBNField; }
      set { iSBNField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType ISSN
    {
      get { return iSSNField; }
      set { iSSNField = value; }
    }
  }
}