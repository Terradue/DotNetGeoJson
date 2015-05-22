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
  [XmlRoot("Node", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class NodeType : AbstractTopoPrimitiveType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private FaceOrTopoSolidPropertyType containerField;
    private DirectedEdgePropertyType[] directedEdgeField;
    private PointPropertyType pointPropertyField;

    [XmlElement]
    public FaceOrTopoSolidPropertyType container
    {
      get { return containerField; }
      set { containerField = value; }
    }

    [XmlElement("directedEdge")]
    public DirectedEdgePropertyType[] directedEdge
    {
      get { return directedEdgeField; }
      set { directedEdgeField = value; }
    }

    [XmlElement]
    public PointPropertyType pointProperty
    {
      get { return pointPropertyField; }
      set { pointPropertyField = value; }
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