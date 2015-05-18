namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodesicStringType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeodesicType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ClothoidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OffsetCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BSplineType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BezierType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CubicSplineType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArcByCenterPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CircleByCenterPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArcStringByBulgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArcByBulgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArcStringType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArcType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CircleType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LineStringSegmentType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractCurveSegment", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractCurveSegmentType
  {

    private string numDerivativesAtStartField;

    private string numDerivativesAtEndField;

    private string numDerivativeInteriorField;

    public AbstractCurveSegmentType()
    {
      numDerivativesAtStartField = "0";
      numDerivativesAtEndField = "0";
      numDerivativeInteriorField = "0";
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string numDerivativesAtStart
    {
      get { return numDerivativesAtStartField; }
      set { numDerivativesAtStartField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string numDerivativesAtEnd
    {
      get { return numDerivativesAtEndField; }
      set { numDerivativesAtEndField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    [System.ComponentModel.DefaultValueAttribute("0")]
    public string numDerivativeInterior
    {
      get { return numDerivativeInteriorField; }
      set { numDerivativeInteriorField = value; }
    }
  }
}