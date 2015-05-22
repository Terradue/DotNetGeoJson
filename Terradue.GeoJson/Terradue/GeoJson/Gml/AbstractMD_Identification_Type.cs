using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_ServiceIdentification_Type))]
  [XmlInclude(typeof (MD_DataIdentification_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract class AbstractMD_Identification_Type : AbstractObject_Type
  {
    private CharacterString_PropertyType abstractField;
    private MD_AggregateInformation_PropertyType[] aggregationInfoField;
    private CI_Citation_PropertyType citationField;
    private CharacterString_PropertyType[] creditField;
    private MD_Keywords_PropertyType[] descriptiveKeywordsField;
    private MD_BrowseGraphic_PropertyType[] graphicOverviewField;
    private CI_ResponsibleParty_PropertyType[] pointOfContactField;
    private CharacterString_PropertyType purposeField;
    private MD_Constraints_PropertyType[] resourceConstraintsField;
    private MD_Format_PropertyType[] resourceFormatField;
    private MD_MaintenanceInformation_PropertyType[] resourceMaintenanceField;
    private MD_Usage_PropertyType[] resourceSpecificUsageField;
    private MD_ProgressCode_PropertyType[] statusField;

    [XmlElement]
    public CI_Citation_PropertyType citation
    {
      get { return citationField; }
      set { citationField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType @abstract
    {
      get { return abstractField; }
      set { abstractField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType purpose
    {
      get { return purposeField; }
      set { purposeField = value; }
    }

    [XmlElement("credit")]
    public CharacterString_PropertyType[] credit
    {
      get { return creditField; }
      set { creditField = value; }
    }

    [XmlElement("status")]
    public MD_ProgressCode_PropertyType[] status
    {
      get { return statusField; }
      set { statusField = value; }
    }

    [XmlElement("pointOfContact")]
    public CI_ResponsibleParty_PropertyType[] pointOfContact
    {
      get { return pointOfContactField; }
      set { pointOfContactField = value; }
    }

    [XmlElement("resourceMaintenance")]
    public MD_MaintenanceInformation_PropertyType[] resourceMaintenance
    {
      get { return resourceMaintenanceField; }
      set { resourceMaintenanceField = value; }
    }

    [XmlElement("graphicOverview")]
    public MD_BrowseGraphic_PropertyType[] graphicOverview
    {
      get { return graphicOverviewField; }
      set { graphicOverviewField = value; }
    }

    [XmlElement("resourceFormat")]
    public MD_Format_PropertyType[] resourceFormat
    {
      get { return resourceFormatField; }
      set { resourceFormatField = value; }
    }

    [XmlElement("descriptiveKeywords")]
    public MD_Keywords_PropertyType[] descriptiveKeywords
    {
      get { return descriptiveKeywordsField; }
      set { descriptiveKeywordsField = value; }
    }

    [XmlElement("resourceSpecificUsage")]
    public MD_Usage_PropertyType[] resourceSpecificUsage
    {
      get { return resourceSpecificUsageField; }
      set { resourceSpecificUsageField = value; }
    }

    [XmlElement("resourceConstraints")]
    public MD_Constraints_PropertyType[] resourceConstraints
    {
      get { return resourceConstraintsField; }
      set { resourceConstraintsField = value; }
    }

    [XmlElement("aggregationInfo")]
    public MD_AggregateInformation_PropertyType[] aggregationInfo
    {
      get { return aggregationInfoField; }
      set { aggregationInfoField = value; }
    }
  }
}