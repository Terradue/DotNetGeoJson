using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (GeodesicType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("GeodesicString", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GeodesicStringType : AbstractCurveSegmentType
  {
    private CurveInterpolationType interpolationField;
    private bool interpolationFieldSpecified;
    private object itemField;

    public GeodesicStringType()
    {
      interpolationField = CurveInterpolationType.geodesic;
    }

    [XmlElement("pointProperty", typeof (PointPropertyType))]
    [XmlElement("pos", typeof (DirectPositionType))]
    [XmlElement("posList", typeof (DirectPositionListType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
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