namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_Georectified_Type))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MD_Georeferenceable_Type))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_GridSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type
  {

    private Integer_PropertyType numberOfDimensionsField;

    private MD_Dimension_PropertyType[] axisDimensionPropertiesField;

    private MD_CellGeometryCode_PropertyType cellGeometryField;

    private Boolean_PropertyType transformationParameterAvailabilityField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType numberOfDimensions
    {
      get { return numberOfDimensionsField; }
      set { numberOfDimensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("axisDimensionProperties")]
    public MD_Dimension_PropertyType[] axisDimensionProperties
    {
      get { return axisDimensionPropertiesField; }
      set { axisDimensionPropertiesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_CellGeometryCode_PropertyType cellGeometry
    {
      get { return cellGeometryField; }
      set { cellGeometryField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Boolean_PropertyType transformationParameterAvailability
    {
      get { return transformationParameterAvailabilityField; }
      set { transformationParameterAvailabilityField = value; }
    }
  }
}