namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TimeNode", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TimeNodeType : AbstractTimeTopologyPrimitiveType
  {

    private TimeEdgePropertyType[] previousEdgeField;

    private TimeEdgePropertyType[] nextEdgeField;

    private TimeInstantPropertyType positionField;

    [System.Xml.Serialization.XmlElementAttribute("previousEdge")]
    public TimeEdgePropertyType[] previousEdge
    {
      get { return previousEdgeField; }
      set { previousEdgeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("nextEdge")]
    public TimeEdgePropertyType[] nextEdge
    {
      get { return nextEdgeField; }
      set { nextEdgeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimeInstantPropertyType position
    {
      get { return positionField; }
      set { positionField = value; }
    }
  }
}