namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Metadata_Type : AbstractObject_Type
  {

    private CharacterString_PropertyType fileIdentifierField;

    private CharacterString_PropertyType languageField;

    private MD_CharacterSetCode_PropertyType characterSetField;

    private CharacterString_PropertyType parentIdentifierField;

    private MD_ScopeCode_PropertyType[] hierarchyLevelField;

    private CharacterString_PropertyType[] hierarchyLevelNameField;

    private CI_ResponsibleParty_PropertyType[] contactField;

    private Date_PropertyType dateStampField;

    private CharacterString_PropertyType metadataStandardNameField;

    private CharacterString_PropertyType metadataStandardVersionField;

    private CharacterString_PropertyType dataSetURIField;

    private PT_Locale_PropertyType[] localeField;

    private MD_SpatialRepresentation_PropertyType[] spatialRepresentationInfoField;

    private MD_ReferenceSystem_PropertyType[] referenceSystemInfoField;

    private MD_MetadataExtensionInformation_PropertyType[] metadataExtensionInfoField;

    private MD_Identification_PropertyType[] identificationInfoField;

    private MD_ContentInformation_PropertyType[] contentInfoField;

    private MD_Distribution_PropertyType distributionInfoField;

    private DQ_DataQuality_PropertyType[] dataQualityInfoField;

    private MD_PortrayalCatalogueReference_PropertyType[] portrayalCatalogueInfoField;

    private MD_Constraints_PropertyType[] metadataConstraintsField;

    private MD_ApplicationSchemaInformation_PropertyType[] applicationSchemaInfoField;

    private MD_MaintenanceInformation_PropertyType metadataMaintenanceField;

    private DS_Aggregate_PropertyType[] seriesField;

    private DS_DataSet_PropertyType[] describesField;

    private ObjectReference_PropertyType[] propertyTypeField;

    private ObjectReference_PropertyType[] featureTypeField;

    private ObjectReference_PropertyType[] featureAttributeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType fileIdentifier
    {
      get { return fileIdentifierField; }
      set { fileIdentifierField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType language
    {
      get { return languageField; }
      set { languageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_CharacterSetCode_PropertyType characterSet
    {
      get { return characterSetField; }
      set { characterSetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType parentIdentifier
    {
      get { return parentIdentifierField; }
      set { parentIdentifierField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("hierarchyLevel")]
    public MD_ScopeCode_PropertyType[] hierarchyLevel
    {
      get { return hierarchyLevelField; }
      set { hierarchyLevelField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("hierarchyLevelName")]
    public CharacterString_PropertyType[] hierarchyLevelName
    {
      get { return hierarchyLevelNameField; }
      set { hierarchyLevelNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("contact")]
    public CI_ResponsibleParty_PropertyType[] contact
    {
      get { return contactField; }
      set { contactField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Date_PropertyType dateStamp
    {
      get { return dateStampField; }
      set { dateStampField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType metadataStandardName
    {
      get { return metadataStandardNameField; }
      set { metadataStandardNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType metadataStandardVersion
    {
      get { return metadataStandardVersionField; }
      set { metadataStandardVersionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType dataSetURI
    {
      get { return dataSetURIField; }
      set { dataSetURIField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("locale")]
    public PT_Locale_PropertyType[] locale
    {
      get { return localeField; }
      set { localeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("spatialRepresentationInfo")]
    public MD_SpatialRepresentation_PropertyType[] spatialRepresentationInfo
    {
      get { return spatialRepresentationInfoField; }
      set { spatialRepresentationInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("referenceSystemInfo")]
    public MD_ReferenceSystem_PropertyType[] referenceSystemInfo
    {
      get { return referenceSystemInfoField; }
      set { referenceSystemInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("metadataExtensionInfo")]
    public MD_MetadataExtensionInformation_PropertyType[] metadataExtensionInfo
    {
      get { return metadataExtensionInfoField; }
      set { metadataExtensionInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("identificationInfo")]
    public MD_Identification_PropertyType[] identificationInfo
    {
      get { return identificationInfoField; }
      set { identificationInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("contentInfo")]
    public MD_ContentInformation_PropertyType[] contentInfo
    {
      get { return contentInfoField; }
      set { contentInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Distribution_PropertyType distributionInfo
    {
      get { return distributionInfoField; }
      set { distributionInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("dataQualityInfo")]
    public DQ_DataQuality_PropertyType[] dataQualityInfo
    {
      get { return dataQualityInfoField; }
      set { dataQualityInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("portrayalCatalogueInfo")]
    public MD_PortrayalCatalogueReference_PropertyType[] portrayalCatalogueInfo
    {
      get { return portrayalCatalogueInfoField; }
      set { portrayalCatalogueInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("metadataConstraints")]
    public MD_Constraints_PropertyType[] metadataConstraints
    {
      get { return metadataConstraintsField; }
      set { metadataConstraintsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("applicationSchemaInfo")]
    public MD_ApplicationSchemaInformation_PropertyType[] applicationSchemaInfo
    {
      get { return applicationSchemaInfoField; }
      set { applicationSchemaInfoField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_MaintenanceInformation_PropertyType metadataMaintenance
    {
      get { return metadataMaintenanceField; }
      set { metadataMaintenanceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("series")]
    public DS_Aggregate_PropertyType[] series
    {
      get { return seriesField; }
      set { seriesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("describes")]
    public DS_DataSet_PropertyType[] describes
    {
      get { return describesField; }
      set { describesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("propertyType")]
    public ObjectReference_PropertyType[] propertyType
    {
      get { return propertyTypeField; }
      set { propertyTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("featureType")]
    public ObjectReference_PropertyType[] featureType
    {
      get { return featureTypeField; }
      set { featureTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("featureAttribute")]
    public ObjectReference_PropertyType[] featureAttribute
    {
      get { return featureAttributeField; }
      set { featureAttributeField = value; }
    }
  }
}