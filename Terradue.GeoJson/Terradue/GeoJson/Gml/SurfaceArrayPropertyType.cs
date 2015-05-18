namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("surfaceMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class SurfaceArrayPropertyType
  {

    private AbstractSurfaceType[] itemsField;

    private bool ownsField;

    public SurfaceArrayPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("CompositeSurface", typeof (CompositeSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("OrientableSurface", typeof (OrientableSurfaceType))]
    [System.Xml.Serialization.XmlElementAttribute("Polygon", typeof (PolygonType))]
    [System.Xml.Serialization.XmlElementAttribute("Surface", typeof (SurfaceType))]
    public PolygonType[] Items
    {
      get { return itemsField as PolygonType[]; }
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