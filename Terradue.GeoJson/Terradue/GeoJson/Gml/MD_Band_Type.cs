namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_Band_Type : MD_RangeDimension_Type
  {

    private Real_PropertyType maxValueField;

    private Real_PropertyType minValueField;

    private UomLength_PropertyType unitsField;

    private Real_PropertyType peakResponseField;

    private Integer_PropertyType bitsPerValueField;

    private Integer_PropertyType toneGradationField;

    private Real_PropertyType scaleFactorField;

    private Real_PropertyType offsetField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType maxValue
    {
      get { return maxValueField; }
      set { maxValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType minValue
    {
      get { return minValueField; }
      set { minValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public UomLength_PropertyType units
    {
      get { return unitsField; }
      set { unitsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType peakResponse
    {
      get { return peakResponseField; }
      set { peakResponseField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType bitsPerValue
    {
      get { return bitsPerValueField; }
      set { bitsPerValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Integer_PropertyType toneGradation
    {
      get { return toneGradationField; }
      set { toneGradationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType scaleFactor
    {
      get { return scaleFactorField; }
      set { scaleFactorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public Real_PropertyType offset
    {
      get { return offsetField; }
      set { offsetField = value; }
    }
  }
}