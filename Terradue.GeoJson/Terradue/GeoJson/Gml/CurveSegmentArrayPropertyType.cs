namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("segments", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class CurveSegmentArrayPropertyType
  {

    private AbstractCurveSegmentType[] itemsField;

    [System.Xml.Serialization.XmlElementAttribute("ArcByCenterPoint", typeof (ArcByCenterPointType))]
    [System.Xml.Serialization.XmlElementAttribute("ArcString", typeof (ArcStringType))]
    [System.Xml.Serialization.XmlElementAttribute("ArcStringByBulge", typeof (ArcStringByBulgeType))]
    [System.Xml.Serialization.XmlElementAttribute("BSpline", typeof (BSplineType))]
    [System.Xml.Serialization.XmlElementAttribute("Clothoid", typeof (ClothoidType))]
    [System.Xml.Serialization.XmlElementAttribute("CubicSpline", typeof (CubicSplineType))]
    [System.Xml.Serialization.XmlElementAttribute("GeodesicString", typeof (GeodesicStringType))]
    [System.Xml.Serialization.XmlElementAttribute("LineStringSegment", typeof (LineStringSegmentType))]
    [System.Xml.Serialization.XmlElementAttribute("OffsetCurve", typeof (OffsetCurveType))]
    public AbstractCurveSegmentType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }
  }
}