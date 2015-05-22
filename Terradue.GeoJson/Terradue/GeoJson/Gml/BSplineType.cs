using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (BezierType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("BSpline", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class BSplineType : AbstractCurveSegmentType
  {
    private string degreeField;
    private CurveInterpolationType interpolationField;
    private bool isPolynomialField;
    private bool isPolynomialFieldSpecified;
    private ItemsChoiceType5[] itemsElementNameField;
    private object[] itemsField;
    private KnotPropertyType[] knotField;
    private KnotTypesType knotTypeField;
    private bool knotTypeFieldSpecified;

    public BSplineType()
    {
      interpolationField = CurveInterpolationType.polynomialSpline;
    }

    [XmlElement("coordinates", typeof (CoordinatesType))]
    [XmlElement("pointProperty", typeof (PointPropertyType))]
    [XmlElement("pointRep", typeof (PointPropertyType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    [XmlElement("posList", typeof (DirectPositionListType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType5[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlElement(DataType = "nonNegativeInteger")]
    public string degree
    {
      get { return degreeField; }
      set { degreeField = value; }
    }

    [XmlElement("knot")]
    public KnotPropertyType[] knot
    {
      get { return knotField; }
      set { knotField = value; }
    }

    [XmlAttribute]
    [DefaultValue(CurveInterpolationType.polynomialSpline)]
    public CurveInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [XmlAttribute]
    public bool isPolynomial
    {
      get { return isPolynomialField; }
      set { isPolynomialField = value; }
    }

    [XmlIgnore]
    public bool isPolynomialSpecified
    {
      get { return isPolynomialFieldSpecified; }
      set { isPolynomialFieldSpecified = value; }
    }

    [XmlAttribute]
    public KnotTypesType knotType
    {
      get { return knotTypeField; }
      set { knotTypeField = value; }
    }

    [XmlIgnore]
    public bool knotTypeSpecified
    {
      get { return knotTypeFieldSpecified; }
      set { knotTypeFieldSpecified = value; }
    }
  }
}