namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("directedEdge", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DirectedEdgePropertyType
  {

    private EdgeType edgeField;

    private SignType orientationField;

    private string nilReasonField;

    private string remoteSchemaField;

    private bool ownsField;

    public DirectedEdgePropertyType()
    {
      orientationField = SignType.Item1;
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public EdgeType Edge
    {
      get { return edgeField; }
      set { edgeField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(SignType.Item1)]
    public SignType orientation
    {
      get { return orientationField; }
      set { orientationField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}