namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Face", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class FaceType : AbstractTopoPrimitiveType
  {

    private NodePropertyType[] isolatedField;

    private DirectedEdgePropertyType[] directedEdgeField;

    private DirectedTopoSolidPropertyType[] directedTopoSolidField;

    private SurfacePropertyType surfacePropertyField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    private bool universalField;

    public FaceType()
    {
      universalField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("isolated")]
    public NodePropertyType[] isolated
    {
      get { return isolatedField; }
      set { isolatedField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
    public DirectedEdgePropertyType[] directedEdge
    {
      get { return directedEdgeField; }
      set { directedEdgeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
    public DirectedTopoSolidPropertyType[] directedTopoSolid
    {
      get { return directedTopoSolidField; }
      set { directedTopoSolidField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public SurfacePropertyType surfaceProperty
    {
      get { return surfacePropertyField; }
      set { surfacePropertyField = value; }
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

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool universal
    {
      get { return universalField; }
      set { universalField = value; }
    }
  }
}