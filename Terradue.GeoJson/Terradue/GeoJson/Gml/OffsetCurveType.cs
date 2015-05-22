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
  [XmlRoot("OffsetCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class OffsetCurveType : AbstractCurveSegmentType
  {
    private LengthType distanceField;
    private CurvePropertyType offsetBaseField;
    private VectorType refDirectionField;

    [XmlElement]
    public CurvePropertyType offsetBase
    {
      get { return offsetBaseField; }
      set { offsetBaseField = value; }
    }

    [XmlElement]
    public LengthType distance
    {
      get { return distanceField; }
      set { distanceField = value; }
    }

    [XmlElement]
    public VectorType refDirection
    {
      get { return refDirectionField; }
      set { refDirectionField = value; }
    }
  }
}