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
  [XmlRoot("curveMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class CurveArrayPropertyType
  {
    private AbstractCurveType[] itemsField;
    private bool ownsField;

    public CurveArrayPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("CompositeCurve", typeof (CompositeCurveType))]
    [XmlElement("Curve", typeof (CurveType))]
    [XmlElement("LineString", typeof (LineStringType))]
    [XmlElement("OrientableCurve", typeof (OrientableCurveType))]
    public AbstractCurveType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}