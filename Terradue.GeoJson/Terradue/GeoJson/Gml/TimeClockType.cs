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
  [XmlRoot("TimeClock", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeClockType : TimeReferenceSystemType
  {
    private TimeCalendarPropertyType[] dateBasisField;
    private StringOrRefType referenceEventField;
    private DateTime referenceTimeField;
    private DateTime utcReferenceField;

    [XmlElement]
    public StringOrRefType referenceEvent
    {
      get { return referenceEventField; }
      set { referenceEventField = value; }
    }

    [XmlElement(DataType = "time")]
    public DateTime referenceTime
    {
      get { return referenceTimeField; }
      set { referenceTimeField = value; }
    }

    [XmlElement(DataType = "time")]
    public DateTime utcReference
    {
      get { return utcReferenceField; }
      set { utcReferenceField = value; }
    }

    [XmlElement("dateBasis")]
    public TimeCalendarPropertyType[] dateBasis
    {
      get { return dateBasisField; }
      set { dateBasisField = value; }
    }
  }
}