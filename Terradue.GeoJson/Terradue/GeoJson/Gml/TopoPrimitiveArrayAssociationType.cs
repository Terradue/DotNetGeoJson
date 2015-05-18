namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("topoPrimitiveMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoPrimitiveArrayAssociationType
  {

    private AbstractTopoPrimitiveType[] itemsField;

    private bool ownsField;

    public TopoPrimitiveArrayAssociationType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("Edge", typeof (EdgeType))]
    [System.Xml.Serialization.XmlElementAttribute("Face", typeof (FaceType))]
    [System.Xml.Serialization.XmlElementAttribute("Node", typeof (NodeType))]
    [System.Xml.Serialization.XmlElementAttribute("TopoSolid", typeof (TopoSolidType))]
    public AbstractTopoPrimitiveType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
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