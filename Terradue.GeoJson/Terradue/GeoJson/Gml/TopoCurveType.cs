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
  [XmlRoot("TopoCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoCurveType : AbstractTopologyType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private DirectedEdgePropertyType[] directedEdgeField;

    [XmlElement("directedEdge")]
    public DirectedEdgePropertyType[] directedEdge
    {
      get { return directedEdgeField; }
      set { directedEdgeField = value; }
    }

    [XmlAttribute]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [XmlIgnore]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}