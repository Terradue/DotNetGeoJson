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
  [XmlRoot("Face", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public class FaceType : AbstractTopoPrimitiveType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private DirectedEdgePropertyType[] directedEdgeField;
    private DirectedTopoSolidPropertyType[] directedTopoSolidField;
    private NodePropertyType[] isolatedField;
    private SurfacePropertyType surfacePropertyField;
    private bool universalField;

    public FaceType()
    {
      universalField = false;
    }

    [XmlElement("isolated")]
    public NodePropertyType[] isolated
    {
      get { return isolatedField; }
      set { isolatedField = value; }
    }

    [XmlElement("directedEdge")]
    public DirectedEdgePropertyType[] directedEdge
    {
      get { return directedEdgeField; }
      set { directedEdgeField = value; }
    }

    [XmlElement("directedTopoSolid")]
    public DirectedTopoSolidPropertyType[] directedTopoSolid
    {
      get { return directedTopoSolidField; }
      set { directedTopoSolidField = value; }
    }

    [XmlElement]
    public SurfacePropertyType surfaceProperty
    {
      get { return surfacePropertyField; }
      set { surfacePropertyField = value; }
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

    [XmlAttribute]
    [DefaultValue(false)]
    public bool universal
    {
      get { return universalField; }
      set { universalField = value; }
    }
  }
}