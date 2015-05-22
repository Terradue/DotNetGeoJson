using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (ArcType))]
  [XmlInclude(typeof (CircleType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("ArcString", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class ArcStringType : AbstractCurveSegmentType
  {
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private ItemsChoiceType2[] itemsElementNameField;
    private object[] itemsField;
    private string numArcField;

    public ArcStringType()
    {
      interpolationField = CurveInterpolationType.circularArc3Points;
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
    public ItemsChoiceType2[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
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