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
  [XmlRoot("OrientableCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class OrientableCurveType : AbstractCurveType
  {
    private CurvePropertyType baseCurveField;
    private SignType orientationField;

    public OrientableCurveType()
    {
      orientationField = SignType.Item1;
    }

    [XmlElement]
    public CurvePropertyType baseCurve
    {
      get { return baseCurveField; }
      set { baseCurveField = value; }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Item1)]
    public SignType orientation
    {
      get { return orientationField; }
      set { orientationField = value; }
    }
  }
}