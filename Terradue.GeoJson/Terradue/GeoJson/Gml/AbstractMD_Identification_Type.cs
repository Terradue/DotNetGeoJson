namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_ServiceIdentification_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_DataIdentification_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public abstract partial class AbstractMD_Identification_Type : AbstractObject_Type
  {

    private CI_Citation_PropertyType citationField;

    private CharacterString_PropertyType abstractField;

    private CharacterString_PropertyType purposeField;

    private CharacterString_PropertyType[] creditField;

    private MD_ProgressCode_PropertyType[] statusField;

    private CI_ResponsibleParty_PropertyType[] pointOfContactField;

    private MD_MaintenanceInformation_PropertyType[] resourceMaintenanceField;

    private MD_BrowseGraphic_PropertyType[] graphicOverviewField;

    private MD_Format_PropertyType[] resourceFormatField;

    private MD_Keywords_PropertyType[] descriptiveKeywordsField;

    private MD_Usage_PropertyType[] resourceSpecificUsageField;

    private MD_Constraints_PropertyType[] resourceConstraintsField;

    private MD_AggregateInformation_PropertyType[] aggregationInfoField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CI_Citation_PropertyType citation
    {
      get { return citationField; }
      set { citationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType @abstract
    {
      get { return abstractField; }
      set { abstractField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType purpose
    {
      get { return purposeField; }
      set { purposeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("credit")]
    public CharacterString_PropertyType[] credit
    {
      get { return creditField; }
      set { creditField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("status")]
    public MD_ProgressCode_PropertyType[] status
    {
      get { return statusField; }
      set { statusField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("pointOfContact")]
    public CI_ResponsibleParty_PropertyType[] pointOfContact
    {
      get { return pointOfContactField; }
      set { pointOfContactField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("resourceMaintenance")]
    public MD_MaintenanceInformation_PropertyType[] resourceMaintenance
    {
      get { return resourceMaintenanceField; }
      set { resourceMaintenanceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("graphicOverview")]
    public MD_BrowseGraphic_PropertyType[] graphicOverview
    {
      get { return graphicOverviewField; }
      set { graphicOverviewField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("resourceFormat")]
    public MD_Format_PropertyType[] resourceFormat
    {
      get { return resourceFormatField; }
      set { resourceFormatField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("descriptiveKeywords")]
    public MD_Keywords_PropertyType[] descriptiveKeywords
    {
      get { return descriptiveKeywordsField; }
      set { descriptiveKeywordsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("resourceSpecificUsage")]
    public MD_Usage_PropertyType[] resourceSpecificUsage
    {
      get { return resourceSpecificUsageField; }
      set { resourceSpecificUsageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("resourceConstraints")]
    public MD_Constraints_PropertyType[] resourceConstraints
    {
      get { return resourceConstraintsField; }
      set { resourceConstraintsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("aggregationInfo")]
    public MD_AggregateInformation_PropertyType[] aggregationInfo
    {
      get { return aggregationInfoField; }
      set { aggregationInfoField = value; }
    }
  }
}