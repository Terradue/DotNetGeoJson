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
  [XmlRoot("Edge", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class EdgeType : AbstractTopoPrimitiveType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private TopoSolidPropertyType containerField;
    private CurvePropertyType curvePropertyField;
    private DirectedFacePropertyType[] directedFaceField;
    private DirectedNodePropertyType[] directedNodeField;

    [XmlElement]
    public TopoSolidPropertyType container
    {
      get { return containerField; }
      set { containerField = value; }
    }

    [XmlElement("directedNode")]
    public DirectedNodePropertyType[] directedNode
    {
      get { return directedNodeField; }
      set { directedNodeField = value; }
    }

    [XmlElement("directedFace")]
    public DirectedFacePropertyType[] directedFace
    {
      get { return directedFaceField; }
      set { directedFaceField = value; }
    }

    [XmlElement]
    public CurvePropertyType curveProperty
    {
      get { return curvePropertyField; }
      set { curvePropertyField = value; }
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