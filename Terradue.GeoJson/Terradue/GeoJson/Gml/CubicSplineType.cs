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
  [XmlRoot("CubicSpline", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CubicSplineType : AbstractCurveSegmentType
  {
    private string degreeField;
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private ItemsChoiceType4[] itemsElementNameField;
    private object[] itemsField;
    private VectorType vectorAtEndField;
    private VectorType vectorAtStartField;

    public CubicSplineType()
    {
      interpolationField = CurveInterpolationType.cubicSpline;
      degreeField = "3";
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
    public ItemsChoiceType4[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [XmlElement]
    public VectorType vectorAtStart
    {
      get { return vectorAtStartField; }
      set { vectorAtStartField = value; }
    }

    [XmlElement]
    public VectorType vectorAtEnd
    {
      get { return vectorAtEndField; }
      set { vectorAtEndField = value; }
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
    public string degree
    {
      get { return degreeField; }
      set { degreeField = value; }
    }
  }
}