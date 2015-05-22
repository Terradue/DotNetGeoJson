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
  [XmlRoot("TimeOrdinalEra", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeOrdinalEraType : DefinitionType
  {
    private TimeNodePropertyType endField;
    private TimePeriodPropertyType extentField;
    private ReferenceType groupField;
    private TimeOrdinalEraPropertyType[] memberField;
    private RelatedTimeType[] relatedTimeField;
    private TimeNodePropertyType startField;

    [XmlElement("relatedTime")]
    public RelatedTimeType[] relatedTime
    {
      get { return relatedTimeField; }
      set { relatedTimeField = value; }
    }

    [XmlElement]
    public TimeNodePropertyType start
    {
      get { return startField; }
      set { startField = value; }
    }

    [XmlElement]
    public TimeNodePropertyType end
    {
      get { return endField; }
      set { endField = value; }
    }

    [XmlElement]
    public TimePeriodPropertyType extent
    {
      get { return extentField; }
      set { extentField = value; }
    }

    [XmlElement("member")]
    public TimeOrdinalEraPropertyType[] member
    {
      get { return memberField; }
      set { memberField = value; }
    }

    [XmlElement]
    public ReferenceType group
    {
      get { return groupField; }
      set { groupField = value; }
    }
  }
}