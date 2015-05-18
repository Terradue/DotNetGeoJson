namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Dimension_Type : AbstractObject_Type
  {

    private MD_DimensionNameTypeCode_PropertyType dimensionNameField;

    private Integer_PropertyType dimensionSizeField;

    private Measure_PropertyType resolutionField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_DimensionNameTypeCode_PropertyType dimensionName
    {
      get { return dimensionNameField; }
      set { dimensionNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType dimensionSize
    {
      get { return dimensionSizeField; }
      set { dimensionSizeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Measure_PropertyType resolution
    {
      get { return resolutionField; }
      set { resolutionField = value; }
    }
  }
}