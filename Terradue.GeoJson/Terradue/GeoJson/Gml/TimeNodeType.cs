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
  [XmlRoot("TimeNode", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TimeNodeType : AbstractTimeTopologyPrimitiveType
  {
    private TimeEdgePropertyType[] nextEdgeField;
    private TimeInstantPropertyType positionField;
    private TimeEdgePropertyType[] previousEdgeField;

    [XmlElement("previousEdge")]
    public TimeEdgePropertyType[] previousEdge
    {
      get { return previousEdgeField; }
      set { previousEdgeField = value; }
    }

    [XmlElement("nextEdge")]
    public TimeEdgePropertyType[] nextEdge
    {
      get { return nextEdgeField; }
      set { nextEdgeField = value; }
    }

    [XmlElement]
    public TimeInstantPropertyType position
    {
      get { return positionField; }
      set { positionField = value; }
    }
  }
}