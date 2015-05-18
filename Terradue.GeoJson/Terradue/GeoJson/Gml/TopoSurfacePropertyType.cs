namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("topoSurfaceProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TopoSurfacePropertyType
  {

    private TopoSurfaceType topoSurfaceField;

    private bool ownsField;

    public TopoSurfacePropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TopoSurfaceType TopoSurface
    {
      get { return topoSurfaceField; }
      set { topoSurfaceField = value; }
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