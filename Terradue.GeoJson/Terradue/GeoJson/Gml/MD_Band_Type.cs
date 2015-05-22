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
  public class MD_Band_Type : MD_RangeDimension_Type
  {
    private Integer_PropertyType bitsPerValueField;
    private Real_PropertyType maxValueField;
    private Real_PropertyType minValueField;
    private Real_PropertyType offsetField;
    private Real_PropertyType peakResponseField;
    private Real_PropertyType scaleFactorField;
    private Integer_PropertyType toneGradationField;
    private UomLength_PropertyType unitsField;

    [XmlElement]
    public Real_PropertyType maxValue
    {
      get { return maxValueField; }
      set { maxValueField = value; }
    }

    [XmlElement]
    public Real_PropertyType minValue
    {
      get { return minValueField; }
      set { minValueField = value; }
    }

    [XmlElement]
    public UomLength_PropertyType units
    {
      get { return unitsField; }
      set { unitsField = value; }
    }

    [XmlElement]
    public Real_PropertyType peakResponse
    {
      get { return peakResponseField; }
      set { peakResponseField = value; }
    }

    [XmlElement]
    public Integer_PropertyType bitsPerValue
    {
      get { return bitsPerValueField; }
      set { bitsPerValueField = value; }
    }

    [XmlElement]
    public Integer_PropertyType toneGradation
    {
      get { return toneGradationField; }
      set { toneGradationField = value; }
    }

    [XmlElement]
    public Real_PropertyType scaleFactor
    {
      get { return scaleFactorField; }
      set { scaleFactorField = value; }
    }

    [XmlElement]
    public Real_PropertyType offset
    {
      get { return offsetField; }
      set { offsetField = value; }
    }
  }
}