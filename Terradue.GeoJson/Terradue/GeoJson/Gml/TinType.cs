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
  [XmlRoot("Tin", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class TinType : SurfaceType
  {
    private LineStringSegmentArrayPropertyType[] breakLinesField;
    private TinTypeControlPoint controlPointField;
    private LengthType maxLengthField;
    private LineStringSegmentArrayPropertyType[] stopLinesField;

    [XmlElement("stopLines")]
    public LineStringSegmentArrayPropertyType[] stopLines
    {
      get { return stopLinesField; }
      set { stopLinesField = value; }
    }

    [XmlElement("breakLines")]
    public LineStringSegmentArrayPropertyType[] breakLines
    {
      get { return breakLinesField; }
      set { breakLinesField = value; }
    }

    [XmlElement]
    public LengthType maxLength
    {
      get { return maxLengthField; }
      set { maxLengthField = value; }
    }

    [XmlElement]
    public TinTypeControlPoint controlPoint
    {
      get { return controlPointField; }
      set { controlPointField = value; }
    }
  }
}