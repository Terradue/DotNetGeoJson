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
  [XmlRoot("TimePeriod", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimePeriodType : AbstractTimeGeometricPrimitiveType
  {
    private string durationField;
    private object item1Field;
    private object itemField;
    private TimeIntervalLengthType timeIntervalField;

    [XmlElement("begin", typeof (TimeInstantPropertyType))]
    [XmlElement("beginPosition", typeof (TimePositionType))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlIgnore]
    public TimePositionType beginPosition
    {
      get { return (TimePositionType) itemField; }
      set { itemField = value; }
    }

    [XmlElement("end", typeof (TimeInstantPropertyType))]
    [XmlElement("endPosition", typeof (TimePositionType))]
    public object Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [XmlIgnore]
    public TimePositionType endPosition
    {
      get { return (TimePositionType) item1Field; }
      set { item1Field = value; }
    }

    [XmlElement(DataType = "duration")]
    public string duration
    {
      get { return durationField; }
      set { durationField = value; }
    }

    [XmlElement]
    public TimeIntervalLengthType timeInterval
    {
      get { return timeIntervalField; }
      set { timeIntervalField = value; }
    }
  }
}