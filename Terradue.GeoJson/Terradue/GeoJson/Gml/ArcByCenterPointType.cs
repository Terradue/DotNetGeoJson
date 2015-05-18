namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CircleByCenterPointType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ArcByCenterPoint", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ArcByCenterPointType : AbstractCurveSegmentType
  {

    private object itemField;

    private ItemChoiceType1 itemElementNameField;

    private LengthType radiusField;

    private AngleType startAngleField;

    private AngleType endAngleField;

    private CurveInterpolationType interpolationField;

    private bool interpolationFieldSpecified;

    private string numArcField;

    public ArcByCenterPointType()
    {
      interpolationField = CurveInterpolationType.circularArcCenterPointWithRadius;
      numArcField = "1";
    }

    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof (CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof (DirectPositionListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public LengthType radius
    {
      get { return radiusField; }
      set { radiusField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public AngleType startAngle
    {
      get { return startAngleField; }
      set { startAngleField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public AngleType endAngle
    {
      get { return endAngleField; }
      set { endAngleField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool interpolationSpecified
    {
      get { return interpolationFieldSpecified; }
      set { interpolationFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string numArc
    {
      get { return numArcField; }
      set { numArcField = value; }
    }
  }
}