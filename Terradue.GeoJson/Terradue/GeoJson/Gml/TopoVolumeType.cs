namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TopoVolume", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoVolumeType : AbstractTopologyType
  {

    private DirectedTopoSolidPropertyType[] directedTopoSolidField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("directedTopoSolid")]
    public DirectedTopoSolidPropertyType[] directedTopoSolid
    {
      get { return directedTopoSolidField; }
      set { directedTopoSolidField = value; }
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