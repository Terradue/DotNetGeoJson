using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (MD_Georectified_Type))]
  [XmlInclude(typeof (MD_Georeferenceable_Type))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class MD_GridSpatialRepresentation_Type : AbstractMD_SpatialRepresentation_Type
  {
    private MD_Dimension_PropertyType[] axisDimensionPropertiesField;
    private MD_CellGeometryCode_PropertyType cellGeometryField;
    private Integer_PropertyType numberOfDimensionsField;
    private Boolean_PropertyType transformationParameterAvailabilityField;

    [XmlElement]
    public Integer_PropertyType numberOfDimensions
    {
      get { return numberOfDimensionsField; }
      set { numberOfDimensionsField = value; }
    }

    [XmlElement("axisDimensionProperties")]
    public MD_Dimension_PropertyType[] axisDimensionProperties
    {
      get { return axisDimensionPropertiesField; }
      set { axisDimensionPropertiesField = value; }
    }

    [XmlElement]
    public MD_CellGeometryCode_PropertyType cellGeometry
    {
      get { return cellGeometryField; }
      set { cellGeometryField = value; }
    }

    [XmlElement]
    public Boolean_PropertyType transformationParameterAvailability
    {
      get { return transformationParameterAvailabilityField; }
      set { transformationParameterAvailabilityField = value; }
    }
  }
}