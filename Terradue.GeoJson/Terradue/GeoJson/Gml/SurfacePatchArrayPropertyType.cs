namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("patches", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class SurfacePatchArrayPropertyType
  {

    private AbstractSurfacePatchType[] itemsField;

    [System.Xml.Serialization.XmlElementAttribute("PolygonPatch", typeof (PolygonPatchType))]
    [System.Xml.Serialization.XmlElementAttribute("Rectangle", typeof (RectangleType))]
    [System.Xml.Serialization.XmlElementAttribute("Triangle", typeof (TriangleType))]
    public AbstractSurfacePatchType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }
  }
}