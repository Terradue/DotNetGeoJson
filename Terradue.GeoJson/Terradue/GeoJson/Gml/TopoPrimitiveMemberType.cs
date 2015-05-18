namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMember", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoPrimitiveMemberType
  {

    private AbstractTopoPrimitiveType itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    private bool ownsField;

    public TopoPrimitiveMemberType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("Edge", typeof (EdgeType))]
    [System.Xml.Serialization.XmlElementAttribute("Face", typeof (FaceType))]
    [System.Xml.Serialization.XmlElementAttribute("Node", typeof (NodeType))]
    [System.Xml.Serialization.XmlElementAttribute("TopoSolid", typeof (TopoSolidType))]
    public AbstractTopoPrimitiveType Item
    {
      get { return itemField; }
      set { itemField = value; }
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