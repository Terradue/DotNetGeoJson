using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (CircleByCenterPointType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("ArcByCenterPoint", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ArcByCenterPointType : AbstractCurveSegmentType
  {
    private AngleType endAngleField;
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private ItemChoiceType1 itemElementNameField;
    private object itemField;
    private string numArcField;
    private LengthType radiusField;
    private AngleType startAngleField;

    public ArcByCenterPointType()
    {
      interpolationField = CurveInterpolationType.circularArcCenterPointWithRadius;
      numArcField = "1";
    }

    [XmlElement("coordinates", typeof (CoordinatesType))]
    [XmlElement("pointProperty", typeof (PointPropertyType))]
    [XmlElement("pointRep", typeof (PointPropertyType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    [XmlElement("posList", typeof (DirectPositionListType))]
    [XmlChoiceIdentifier("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    [XmlIgnore]
    public ItemChoiceType1 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [XmlElement]
    public LengthType radius
    {
      get { return radiusField; }
      set { radiusField = value; }
    }

    [XmlElement]
    public AngleType startAngle
    {
      get { return startAngleField; }
      set { startAngleField = value; }
    }

    [XmlElement]
    public AngleType endAngle
    {
      get { return endAngleField; }
      set { endAngleField = value; }
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

    [XmlAttribute(DataType = "integer")]
    public string numArc
    {
      get { return numArcField; }
      set { numArcField = value; }
    }
  }
}