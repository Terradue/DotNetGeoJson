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
  public class MD_Dimension_Type : AbstractObject_Type
  {
    private MD_DimensionNameTypeCode_PropertyType dimensionNameField;
    private Integer_PropertyType dimensionSizeField;
    private Measure_PropertyType resolutionField;

    [XmlElement]
    public MD_DimensionNameTypeCode_PropertyType dimensionName
    {
      get { return dimensionNameField; }
      set { dimensionNameField = value; }
    }

    [XmlElement]
    public Integer_PropertyType dimensionSize
    {
      get { return dimensionSizeField; }
      set { dimensionSizeField = value; }
    }

    [XmlElement]
    public Measure_PropertyType resolution
    {
      get { return resolutionField; }
      set { resolutionField = value; }
    }
  }
}