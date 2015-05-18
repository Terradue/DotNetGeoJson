namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("geometryMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GeometryArrayPropertyType
  {

    private GeometricComplexType[] itemsField;

    private bool ownsField;

    public GeometryArrayPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("GeometricComplex")]
    public GeometricComplexType[] Items
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