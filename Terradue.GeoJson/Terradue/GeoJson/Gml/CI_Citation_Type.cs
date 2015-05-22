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
  public class CI_Citation_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType[] alternateTitleField;
    private CI_ResponsibleParty_PropertyType[] citedResponsiblePartyField;
    private CharacterString_PropertyType collectiveTitleField;
    private CI_Date_PropertyType[] dateField;
    private Date_PropertyType editionDateField;
    private CharacterString_PropertyType editionField;
    private MD_Identifier_PropertyType[] identifierField;
    private CharacterString_PropertyType iSBNField;
    private CharacterString_PropertyType iSSNField;
    private CharacterString_PropertyType otherCitationDetailsField;
    private CI_PresentationFormCode_PropertyType[] presentationFormField;
    private CI_Series_PropertyType seriesField;
    private CharacterString_PropertyType titleField;

    [XmlElement]
    public CharacterString_PropertyType title
    {
      get { return titleField; }
      set { titleField = value; }
    }

    [XmlElement("alternateTitle")]
    public CharacterString_PropertyType[] alternateTitle
    {
      get { return alternateTitleField; }
      set { alternateTitleField = value; }
    }

    [XmlElement("date")]
    public CI_Date_PropertyType[] date
    {
      get { return dateField; }
      set { dateField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType edition
    {
      get { return editionField; }
      set { editionField = value; }
    }

    [XmlElement]
    public Date_PropertyType editionDate
    {
      get { return editionDateField; }
      set { editionDateField = value; }
    }

    [XmlElement("identifier")]
    public MD_Identifier_PropertyType[] identifier
    {
      get { return identifierField; }
      set { identifierField = value; }
    }

    [XmlElement("citedResponsibleParty")]
    public CI_ResponsibleParty_PropertyType[] citedResponsibleParty
    {
      get { return citedResponsiblePartyField; }
      set { citedResponsiblePartyField = value; }
    }

    [XmlElement("presentationForm")]
    public CI_PresentationFormCode_PropertyType[] presentationForm
    {
      get { return presentationFormField; }
      set { presentationFormField = value; }
    }

    [XmlElement]
    public CI_Series_PropertyType series
    {
      get { return seriesField; }
      set { seriesField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType otherCitationDetails
    {
      get { return otherCitationDetailsField; }
      set { otherCitationDetailsField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType collectiveTitle
    {
      get { return collectiveTitleField; }
      set { collectiveTitleField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType ISBN
    {
      get { return iSBNField; }
      set { iSBNField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType ISSN
    {
      get { return iSSNField; }
      set { iSSNField = value; }
    }
  }
}