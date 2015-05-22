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
  public class MD_ImageDescription_Type : MD_CoverageDescription_Type
  {
    private Boolean_PropertyType cameraCalibrationInformationAvailabilityField;
    private Real_PropertyType cloudCoverPercentageField;
    private Integer_PropertyType compressionGenerationQuantityField;
    private Boolean_PropertyType filmDistortionInformationAvailabilityField;
    private Real_PropertyType illuminationAzimuthAngleField;
    private Real_PropertyType illuminationElevationAngleField;
    private MD_Identifier_PropertyType imageQualityCodeField;
    private MD_ImagingConditionCode_PropertyType imagingConditionField;
    private Boolean_PropertyType lensDistortionInformationAvailabilityField;
    private MD_Identifier_PropertyType processingLevelCodeField;
    private Boolean_PropertyType radiometricCalibrationDataAvailabilityField;
    private Boolean_PropertyType triangulationIndicatorField;

    [XmlElement]
    public Real_PropertyType illuminationElevationAngle
    {
      get { return illuminationElevationAngleField; }
      set { illuminationElevationAngleField = value; }
    }

    [XmlElement]
    public Real_PropertyType illuminationAzimuthAngle
    {
      get { return illuminationAzimuthAngleField; }
      set { illuminationAzimuthAngleField = value; }
    }

    [XmlElement]
    public MD_ImagingConditionCode_PropertyType imagingCondition
    {
      get { return imagingConditionField; }
      set { imagingConditionField = value; }
    }

    [XmlElement]
    public MD_Identifier_PropertyType imageQualityCode
    {
      get { return imageQualityCodeField; }
      set { imageQualityCodeField = value; }
    }

    [XmlElement]
    public Real_PropertyType cloudCoverPercentage
    {
      get { return cloudCoverPercentageField; }
      set { cloudCoverPercentageField = value; }
    }

    [XmlElement]
    public MD_Identifier_PropertyType processingLevelCode
    {
      get { return processingLevelCodeField; }
      set { processingLevelCodeField = value; }
    }

    [XmlElement]
    public Integer_PropertyType compressionGenerationQuantity
    {
      get { return compressionGenerationQuantityField; }
      set { compressionGenerationQuantityField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType triangulationIndicator
    {
      get { return triangulationIndicatorField; }
      set { triangulationIndicatorField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType radiometricCalibrationDataAvailability
    {
      get { return radiometricCalibrationDataAvailabilityField; }
      set { radiometricCalibrationDataAvailabilityField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType cameraCalibrationInformationAvailability
    {
      get { return cameraCalibrationInformationAvailabilityField; }
      set { cameraCalibrationInformationAvailabilityField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType filmDistortionInformationAvailability
    {
      get { return filmDistortionInformationAvailabilityField; }
      set { filmDistortionInformationAvailabilityField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType lensDistortionInformationAvailability
    {
      get { return lensDistortionInformationAvailabilityField; }
      set { lensDistortionInformationAvailabilityField = value; }
    }
  }
}