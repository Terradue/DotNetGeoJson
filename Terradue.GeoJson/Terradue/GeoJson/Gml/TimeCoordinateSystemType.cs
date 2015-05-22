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
  [XmlRoot("TimeCoordinateSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeCoordinateSystemType : TimeReferenceSystemType
  {
    private TimeIntervalLengthType intervalField;
    private object itemField;

    [XmlElement("origin", typeof (TimeInstantPropertyType))]
    [XmlElement("originPosition", typeof (TimePositionType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlElement]
    public TimeIntervalLengthType interval
    {
      get { return intervalField; }
      set { intervalField = value; }
    }
  }
}