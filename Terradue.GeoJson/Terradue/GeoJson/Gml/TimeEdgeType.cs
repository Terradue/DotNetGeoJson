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
  [XmlRoot("TimeEdge", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeEdgeType : AbstractTimeTopologyPrimitiveType
  {
    private TimeNodePropertyType endField;
    private TimePeriodPropertyType extentField;
    private TimeNodePropertyType startField;

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
  }
}