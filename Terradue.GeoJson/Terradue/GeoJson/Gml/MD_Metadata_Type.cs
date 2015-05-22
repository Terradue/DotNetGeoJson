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
  public class MD_Metadata_Type : AbstractObject_Type
  {
    private MD_ApplicationSchemaInformation_PropertyType[] applicationSchemaInfoField;
    private MD_CharacterSetCode_PropertyType characterSetField;
    private CI_ResponsibleParty_PropertyType[] contactField;
    private MD_ContentInformation_PropertyType[] contentInfoField;
    private DQ_DataQuality_PropertyType[] dataQualityInfoField;
    private CharacterString_PropertyType dataSetURIField;
    private Date_PropertyType dateStampField;
    private DS_DataSet_PropertyType[] describesField;
    private MD_Distribution_PropertyType distributionInfoField;
    private ObjectReference_PropertyType[] featureAttributeField;
    private ObjectReference_PropertyType[] featureTypeField;
    private CharacterString_PropertyType fileIdentifierField;
    private MD_ScopeCode_PropertyType[] hierarchyLevelField;
    private CharacterString_PropertyType[] hierarchyLevelNameField;
    private MD_Identification_PropertyType[] identificationInfoField;
    private CharacterString_PropertyType languageField;
    private PT_Locale_PropertyType[] localeField;
    private MD_Constraints_PropertyType[] metadataConstraintsField;
    private MD_MetadataExtensionInformation_PropertyType[] metadataExtensionInfoField;
    private MD_MaintenanceInformation_PropertyType metadataMaintenanceField;
    private CharacterString_PropertyType metadataStandardNameField;
    private CharacterString_PropertyType metadataStandardVersionField;
    private CharacterString_PropertyType parentIdentifierField;
    private MD_PortrayalCatalogueReference_PropertyType[] portrayalCatalogueInfoField;
    private ObjectReference_PropertyType[] propertyTypeField;
    private MD_ReferenceSystem_PropertyType[] referenceSystemInfoField;
    private DS_Aggregate_PropertyType[] seriesField;
    private MD_SpatialRepresentation_PropertyType[] spatialRepresentationInfoField;

    [XmlElement]
    public CharacterString_PropertyType fileIdentifier
    {
      get { return fileIdentifierField; }
      set { fileIdentifierField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType language
    {
      get { return languageField; }
      set { languageField = value; }
    }

    [XmlElement]
    public MD_CharacterSetCode_PropertyType characterSet
    {
      get { return characterSetField; }
      set { characterSetField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType parentIdentifier
    {
      get { return parentIdentifierField; }
      set { parentIdentifierField = value; }
    }

    [XmlElement("hierarchyLevel")]
    public MD_ScopeCode_PropertyType[] hierarchyLevel
    {
      get { return hierarchyLevelField; }
      set { hierarchyLevelField = value; }
    }

    [XmlElement("hierarchyLevelName")]
    public CharacterString_PropertyType[] hierarchyLevelName
    {
      get { return hierarchyLevelNameField; }
      set { hierarchyLevelNameField = value; }
    }

    [XmlElement("contact")]
    public CI_ResponsibleParty_PropertyType[] contact
    {
      get { return contactField; }
      set { contactField = value; }
    }

    [XmlElement]
    public Date_PropertyType dateStamp
    {
      get { return dateStampField; }
      set { dateStampField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType metadataStandardName
    {
      get { return metadataStandardNameField; }
      set { metadataStandardNameField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType metadataStandardVersion
    {
      get { return metadataStandardVersionField; }
      set { metadataStandardVersionField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType dataSetURI
    {
      get { return dataSetURIField; }
      set { dataSetURIField = value; }
    }

    [XmlElement("locale")]
    public PT_Locale_PropertyType[] locale
    {
      get { return localeField; }
      set { localeField = value; }
    }

    [XmlElement("spatialRepresentationInfo")]
    public MD_SpatialRepresentation_PropertyType[] spatialRepresentationInfo
    {
      get { return spatialRepresentationInfoField; }
      set { spatialRepresentationInfoField = value; }
    }

    [XmlElement("referenceSystemInfo")]
    public MD_ReferenceSystem_PropertyType[] referenceSystemInfo
    {
      get { return referenceSystemInfoField; }
      set { referenceSystemInfoField = value; }
    }

    [XmlElement("metadataExtensionInfo")]
    public MD_MetadataExtensionInformation_PropertyType[] metadataExtensionInfo
    {
      get { return metadataExtensionInfoField; }
      set { metadataExtensionInfoField = value; }
    }

    [XmlElement("identificationInfo")]
    public MD_Identification_PropertyType[] identificationInfo
    {
      get { return identificationInfoField; }
      set { identificationInfoField = value; }
    }

    [XmlElement("contentInfo")]
    public MD_ContentInformation_PropertyType[] contentInfo
    {
      get { return contentInfoField; }
      set { contentInfoField = value; }
    }

    [XmlElement]
    public MD_Distribution_PropertyType distributionInfo
    {
      get { return distributionInfoField; }
      set { distributionInfoField = value; }
    }

    [XmlElement("dataQualityInfo")]
    public DQ_DataQuality_PropertyType[] dataQualityInfo
    {
      get { return dataQualityInfoField; }
      set { dataQualityInfoField = value; }
    }

    [XmlElement("portrayalCatalogueInfo")]
    public MD_PortrayalCatalogueReference_PropertyType[] portrayalCatalogueInfo
    {
      get { return portrayalCatalogueInfoField; }
      set { portrayalCatalogueInfoField = value; }
    }

    [XmlElement("metadataConstraints")]
    public MD_Constraints_PropertyType[] metadataConstraints
    {
      get { return metadataConstraintsField; }
      set { metadataConstraintsField = value; }
    }

    [XmlElement("applicationSchemaInfo")]
    public MD_ApplicationSchemaInformation_PropertyType[] applicationSchemaInfo
    {
      get { return applicationSchemaInfoField; }
      set { applicationSchemaInfoField = value; }
    }

    [XmlElement]
    public MD_MaintenanceInformation_PropertyType metadataMaintenance
    {
      get { return metadataMaintenanceField; }
      set { metadataMaintenanceField = value; }
    }

    [XmlElement("series")]
    public DS_Aggregate_PropertyType[] series
    {
      get { return seriesField; }
      set { seriesField = value; }
    }

    [XmlElement("describes")]
    public DS_DataSet_PropertyType[] describes
    {
      get { return describesField; }
      set { describesField = value; }
    }

    [XmlElement("propertyType")]
    public ObjectReference_PropertyType[] propertyType
    {
      get { return propertyTypeField; }
      set { propertyTypeField = value; }
    }

    [XmlElement("featureType")]
    public ObjectReference_PropertyType[] featureType
    {
      get { return featureTypeField; }
      set { featureTypeField = value; }
    }

    [XmlElement("featureAttribute")]
    public ObjectReference_PropertyType[] featureAttribute
    {
      get { return featureAttributeField; }
      set { featureAttributeField = value; }
    }
  }
}