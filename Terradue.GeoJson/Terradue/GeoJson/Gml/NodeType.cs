namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Node", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class NodeType : AbstractTopoPrimitiveType
  {

    private FaceOrTopoSolidPropertyType containerField;

    private DirectedEdgePropertyType[] directedEdgeField;

    private PointPropertyType pointPropertyField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute()]
    public FaceOrTopoSolidPropertyType container
    {
      get { return containerField; }
      set { containerField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
    public DirectedEdgePropertyType[] directedEdge
    {
      get { return directedEdgeField; }
      set { directedEdgeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public PointPropertyType pointProperty
    {
      get { return pointPropertyField; }
      set { pointPropertyField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}