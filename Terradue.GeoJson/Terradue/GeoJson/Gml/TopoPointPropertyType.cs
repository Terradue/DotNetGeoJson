namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("topoPointProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoPointPropertyType
  {

    private TopoPointType topoPointField;

    private bool ownsField;

    public TopoPointPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TopoPointType TopoPoint
    {
      get { return topoPointField; }
      set { topoPointField = value; }
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