namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ImageDescription_Type : MD_CoverageDescription_Type
  {

    private Real_PropertyType illuminationElevationAngleField;

    private Real_PropertyType illuminationAzimuthAngleField;

    private MD_ImagingConditionCode_PropertyType imagingConditionField;

    private MD_Identifier_PropertyType imageQualityCodeField;

    private Real_PropertyType cloudCoverPercentageField;

    private MD_Identifier_PropertyType processingLevelCodeField;

    private Integer_PropertyType compressionGenerationQuantityField;

    private Boolean_PropertyType triangulationIndicatorField;

    private Boolean_PropertyType radiometricCalibrationDataAvailabilityField;

    private Boolean_PropertyType cameraCalibrationInformationAvailabilityField;

    private Boolean_PropertyType filmDistortionInformationAvailabilityField;

    private Boolean_PropertyType lensDistortionInformationAvailabilityField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType illuminationElevationAngle
    {
      get { return illuminationElevationAngleField; }
      set { illuminationElevationAngleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType illuminationAzimuthAngle
    {
      get { return illuminationAzimuthAngleField; }
      set { illuminationAzimuthAngleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ImagingConditionCode_PropertyType imagingCondition
    {
      get { return imagingConditionField; }
      set { imagingConditionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Identifier_PropertyType imageQualityCode
    {
      get { return imageQualityCodeField; }
      set { imageQualityCodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType cloudCoverPercentage
    {
      get { return cloudCoverPercentageField; }
      set { cloudCoverPercentageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_Identifier_PropertyType processingLevelCode
    {
      get { return processingLevelCodeField; }
      set { processingLevelCodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType compressionGenerationQuantity
    {
      get { return compressionGenerationQuantityField; }
      set { compressionGenerationQuantityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType triangulationIndicator
    {
      get { return triangulationIndicatorField; }
      set { triangulationIndicatorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType radiometricCalibrationDataAvailability
    {
      get { return radiometricCalibrationDataAvailabilityField; }
      set { radiometricCalibrationDataAvailabilityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType cameraCalibrationInformationAvailability
    {
      get { return cameraCalibrationInformationAvailabilityField; }
      set { cameraCalibrationInformationAvailabilityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType filmDistortionInformationAvailability
    {
      get { return filmDistortionInformationAvailabilityField; }
      set { filmDistortionInformationAvailabilityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType lensDistortionInformationAvailability
    {
      get { return lensDistortionInformationAvailabilityField; }
      set { lensDistortionInformationAvailabilityField = value; }
    }
  }
}