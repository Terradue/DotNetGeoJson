namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Georectified_Type : MD_GridSpatialRepresentation_Type
  {

    private Boolean_PropertyType checkPointAvailabilityField;

    private CharacterString_PropertyType checkPointDescriptionField;

    private GM_Point_PropertyType[] cornerPointsField;

    private GM_Point_PropertyType centerPointField;

    private MD_PixelOrientationCode_PropertyType pointInPixelField;

    private CharacterString_PropertyType transformationDimensionDescriptionField;

    private CharacterString_PropertyType[] transformationDimensionMappingField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType checkPointAvailability
    {
      get { return checkPointAvailabilityField; }
      set { checkPointAvailabilityField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType checkPointDescription
    {
      get { return checkPointDescriptionField; }
      set { checkPointDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("cornerPoints")]
    public GM_Point_PropertyType[] cornerPoints
    {
      get { return cornerPointsField; }
      set { cornerPointsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public GM_Point_PropertyType centerPoint
    {
      get { return centerPointField; }
      set { centerPointField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_PixelOrientationCode_PropertyType pointInPixel
    {
      get { return pointInPixelField; }
      set { pointInPixelField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CharacterString_PropertyType transformationDimensionDescription
    {
      get { return transformationDimensionDescriptionField; }
      set { transformationDimensionDescriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("transformationDimensionMapping")]
    public CharacterString_PropertyType[] transformationDimensionMapping
    {
      get { return transformationDimensionMappingField; }
      set { transformationDimensionMappingField = value; }
    }
  }
}