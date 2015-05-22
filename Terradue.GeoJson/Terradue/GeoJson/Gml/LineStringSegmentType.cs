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
  [XmlRoot("LineStringSegment", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class LineStringSegmentType : AbstractCurveSegmentType
  {
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private ItemsChoiceType1[] itemsElementNameField;
    private object[] itemsField;

    public LineStringSegmentType()
    {
      interpolationField = CurveInterpolationType.linear;
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
    public ItemsChoiceType1[] ItemsElementName
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
  }
}