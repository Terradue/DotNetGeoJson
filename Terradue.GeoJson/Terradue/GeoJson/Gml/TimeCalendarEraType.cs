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
  [XmlRoot("TimeCalendarEra", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeCalendarEraType : DefinitionType
  {
    private TimePeriodPropertyType epochOfUseField;
    private decimal julianReferenceField;
    private string referenceDateField;
    private StringOrRefType referenceEventField;

    [XmlElement]
    public StringOrRefType referenceEvent
    {
      get { return referenceEventField; }
      set { referenceEventField = value; }
    }

    [XmlElement]
    public string referenceDate
    {
      get { return referenceDateField; }
      set { referenceDateField = value; }
    }

    [XmlElement]
    public decimal julianReference
    {
      get { return julianReferenceField; }
      set { julianReferenceField = value; }
    }

    [XmlElement]
    public TimePeriodPropertyType epochOfUse
    {
      get { return epochOfUseField; }
      set { epochOfUseField = value; }
    }
  }
}