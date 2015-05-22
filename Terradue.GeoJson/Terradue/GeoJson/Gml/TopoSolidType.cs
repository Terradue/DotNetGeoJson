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
  [XmlRoot("TopoSolid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoSolidType : AbstractTopoPrimitiveType
  {
    private AggregationType aggregationTypeField;
    private bool aggregationTypeFieldSpecified;
    private DirectedFacePropertyType[] directedFaceField;
    private NodeOrEdgePropertyType[] isolatedField;
    private SolidPropertyType solidPropertyField;
    private bool universalField;

    public TopoSolidType()
    {
      universalField = false;
    }

    [XmlElement("isolated")]
    public NodeOrEdgePropertyType[] isolated
    {
      get { return isolatedField; }
      set { isolatedField = value; }
    }

    [XmlElement("directedFace")]
    public DirectedFacePropertyType[] directedFace
    {
      get { return directedFaceField; }
      set { directedFaceField = value; }
    }

    [XmlElement]
    public SolidPropertyType solidProperty
    {
      get { return solidPropertyField; }
      set { solidPropertyField = value; }
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