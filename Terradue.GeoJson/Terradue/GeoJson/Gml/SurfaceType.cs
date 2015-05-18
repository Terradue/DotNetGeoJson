namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TinType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Surface", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public partial class SurfaceType : AbstractSurfaceType
  {

    private SurfacePatchArrayPropertyType itemField;

    private ItemChoiceType2 itemElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("patches", typeof (SurfacePatchArrayPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("polygonPatches", typeof (SurfacePatchArrayPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("trianglePatches", typeof (SurfacePatchArrayPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public SurfacePatchArrayPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
}