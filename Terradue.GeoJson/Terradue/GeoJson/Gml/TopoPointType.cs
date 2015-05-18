namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TopoPoint", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoPointType : AbstractTopologyType
  {

    private DirectedNodePropertyType directedNodeField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DirectedNodePropertyType directedNode
    {
      get { return directedNodeField; }
      set { directedNodeField = value; }
    }
  }
}