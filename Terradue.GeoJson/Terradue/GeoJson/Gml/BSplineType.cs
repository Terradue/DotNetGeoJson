namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BezierType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("BSpline", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class BSplineType : AbstractCurveSegmentType
  {

    private object[] itemsField;

    private ItemsChoiceType5[] itemsElementNameField;

    private string degreeField;

    private KnotPropertyType[] knotField;

    private CurveInterpolationType interpolationField;

    private bool isPolynomialField;

    private bool isPolynomialFieldSpecified;

    private KnotTypesType knotTypeField;

    private bool knotTypeFieldSpecified;

    public BSplineType()
    {
      interpolationField = CurveInterpolationType.polynomialSpline;
    }

    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof (CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof (DirectPositionListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType5[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string degree
    {
      get { return degreeField; }
      set { degreeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("knot")]
    public KnotPropertyType[] knot
    {
      get { return knotField; }
      set { knotField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(CurveInterpolationType.polynomialSpline)]
    public CurveInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isPolynomial
    {
      get { return isPolynomialField; }
      set { isPolynomialField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isPolynomialSpecified
    {
      get { return isPolynomialFieldSpecified; }
      set { isPolynomialFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public KnotTypesType knotType
    {
      get { return knotTypeField; }
      set { knotTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool knotTypeSpecified
    {
      get { return knotTypeFieldSpecified; }
      set { knotTypeFieldSpecified = value; }
    }
  }
}