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
  [XmlRoot("segments", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CurveSegmentArrayPropertyType
  {
    private AbstractCurveSegmentType[] itemsField;

    [XmlElement("ArcByCenterPoint", typeof (ArcByCenterPointType))]
    [XmlElement("ArcString", typeof (ArcStringType))]
    [XmlElement("ArcStringByBulge", typeof (ArcStringByBulgeType))]
    [XmlElement("BSpline", typeof (BSplineType))]
    [XmlElement("Clothoid", typeof (ClothoidType))]
    [XmlElement("CubicSpline", typeof (CubicSplineType))]
    [XmlElement("GeodesicString", typeof (GeodesicStringType))]
    [XmlElement("LineStringSegment", typeof (LineStringSegmentType))]
    [XmlElement("OffsetCurve", typeof (OffsetCurveType))]
    public AbstractCurveSegmentType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }
  }
}