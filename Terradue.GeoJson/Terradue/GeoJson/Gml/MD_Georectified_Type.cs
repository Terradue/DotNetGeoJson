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
  public class MD_Georectified_Type : MD_GridSpatialRepresentation_Type
  {
    private GM_Point_PropertyType centerPointField;
    private Boolean_PropertyType checkPointAvailabilityField;
    private CharacterString_PropertyType checkPointDescriptionField;
    private GM_Point_PropertyType[] cornerPointsField;
    private MD_PixelOrientationCode_PropertyType pointInPixelField;
    private CharacterString_PropertyType transformationDimensionDescriptionField;
    private CharacterString_PropertyType[] transformationDimensionMappingField;

    [XmlElement]
    public Boolean_PropertyType checkPointAvailability
    {
      get { return checkPointAvailabilityField; }
      set { checkPointAvailabilityField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType checkPointDescription
    {
      get { return checkPointDescriptionField; }
      set { checkPointDescriptionField = value; }
    }

    [XmlElement("cornerPoints")]
    public GM_Point_PropertyType[] cornerPoints
    {
      get { return cornerPointsField; }
      set { cornerPointsField = value; }
    }

    [XmlElement]
    public GM_Point_PropertyType centerPoint
    {
      get { return centerPointField; }
      set { centerPointField = value; }
    }

    [XmlElement]
    public MD_PixelOrientationCode_PropertyType pointInPixel
    {
      get { return pointInPixelField; }
      set { pointInPixelField = value; }
    }

    [XmlElement]
    public CharacterString_PropertyType transformationDimensionDescription
    {
      get { return transformationDimensionDescriptionField; }
      set { transformationDimensionDescriptionField = value; }
    }

    [XmlElement("transformationDimensionMapping")]
    public CharacterString_PropertyType[] transformationDimensionMapping
    {
      get { return transformationDimensionMappingField; }
      set { transformationDimensionMappingField = value; }
    }
  }
}