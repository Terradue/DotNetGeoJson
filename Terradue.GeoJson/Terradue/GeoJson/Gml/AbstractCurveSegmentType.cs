using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (GeodesicStringType))]
  [XmlInclude(typeof (GeodesicType))]
  [XmlInclude(typeof (ClothoidType))]
  [XmlInclude(typeof (OffsetCurveType))]
  [XmlInclude(typeof (BSplineType))]
  [XmlInclude(typeof (BezierType))]
  [XmlInclude(typeof (CubicSplineType))]
  [XmlInclude(typeof (ArcByCenterPointType))]
  [XmlInclude(typeof (CircleByCenterPointType))]
  [XmlInclude(typeof (ArcStringByBulgeType))]
  [XmlInclude(typeof (ArcByBulgeType))]
  [XmlInclude(typeof (ArcStringType))]
  [XmlInclude(typeof (ArcType))]
  [XmlInclude(typeof (CircleType))]
  [XmlInclude(typeof (LineStringSegmentType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractCurveSegment", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractCurveSegmentType
  {
    private string numDerivativeInteriorField;
    private string numDerivativesAtEndField;
    private string numDerivativesAtStartField;

    public AbstractCurveSegmentType()
    {
      numDerivativesAtStartField = "0";
      numDerivativesAtEndField = "0";
      numDerivativeInteriorField = "0";
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    public string numDerivativesAtStart
    {
      get { return numDerivativesAtStartField; }
      set { numDerivativesAtStartField = value; }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    public string numDerivativesAtEnd
    {
      get { return numDerivativesAtEndField; }
      set { numDerivativesAtEndField = value; }
    }

    [XmlAttribute(DataType = "integer")]
    [DefaultValue("0")]
    public string numDerivativeInterior
    {
      get { return numDerivativeInteriorField; }
      set { numDerivativeInteriorField = value; }
    }
  }
}