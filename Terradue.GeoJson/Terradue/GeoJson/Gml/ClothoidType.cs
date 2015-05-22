using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("Clothoid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ClothoidType : AbstractCurveSegmentType
  {
    private double endParameterField;
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private ClothoidTypeRefLocation refLocationField;
    private decimal scaleFactorField;
    private double startParameterField;

    public ClothoidType()
    {
      interpolationField = CurveInterpolationType.clothoid;
    }

    [XmlElement]
    public ClothoidTypeRefLocation refLocation
    {
      get { return refLocationField; }
      set { refLocationField = value; }
    }

    [XmlElement]
    public decimal scaleFactor
    {
      get { return scaleFactorField; }
      set { scaleFactorField = value; }
    }

    [XmlElement]
    public double startParameter
    {
      get { return startParameterField; }
      set { startParameterField = value; }
    }

    [XmlElement]
    public double endParameter
    {
      get { return endParameterField; }
      set { endParameterField = value; }
    }

    [XmlAttribute]
    public CurveInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [XmlIgnore]
    public bool interpolationSpecified
    {
      get { return interpolationFieldSpecified; }
      set { interpolationFieldSpecified = value; }
    }
  }
}