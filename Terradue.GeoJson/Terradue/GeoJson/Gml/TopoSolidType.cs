namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TopoSolid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoSolidType : AbstractTopoPrimitiveType
  {

    private NodeOrEdgePropertyType[] isolatedField;

    private DirectedFacePropertyType[] directedFaceField;

    private SolidPropertyType solidPropertyField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    private bool universalField;

    public TopoSolidType()
    {
      universalField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("isolated")]
    public NodeOrEdgePropertyType[] isolated
    {
      get { return isolatedField; }
      set { isolatedField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("directedFace")]
    public DirectedFacePropertyType[] directedFace
    {
      get { return directedFaceField; }
      set { directedFaceField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public SolidPropertyType solidProperty
    {
      get { return solidPropertyField; }
      set { solidPropertyField = value; }
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