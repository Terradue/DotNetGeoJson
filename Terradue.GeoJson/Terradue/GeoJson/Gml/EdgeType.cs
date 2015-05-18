namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Edge", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class EdgeType : AbstractTopoPrimitiveType
  {

    private TopoSolidPropertyType containerField;

    private DirectedNodePropertyType[] directedNodeField;

    private DirectedFacePropertyType[] directedFaceField;

    private CurvePropertyType curvePropertyField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute()]
    public TopoSolidPropertyType container
    {
      get { return containerField; }
      set { containerField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("directedNode")]
    public DirectedNodePropertyType[] directedNode
    {
      get { return directedNodeField; }
      set { directedNodeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("directedFace")]
    public DirectedFacePropertyType[] directedFace
    {
      get { return directedFaceField; }
      set { directedFaceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CurvePropertyType curveProperty
    {
      get { return curvePropertyField; }
      set { curvePropertyField = value; }
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