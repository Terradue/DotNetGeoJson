namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Polygon", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class PolygonType : AbstractSurfaceType
  {

    private AbstractRingPropertyType exteriorField;

    private AbstractRingPropertyType[] interiorField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public AbstractRingPropertyType exterior
    {
      get { return exteriorField; }
      set { exteriorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("interior")]
    public AbstractRingPropertyType[] interior
    {
      get { return interiorField; }
      set { interiorField = value; }
    }
  }
}