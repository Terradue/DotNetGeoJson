namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("solidMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class SolidArrayPropertyType
  {

    private AbstractSolidType[] itemsField;

    private bool ownsField;

    public SolidArrayPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("CompositeSolid", typeof (CompositeSolidType))]
    [System.Xml.Serialization.XmlElementAttribute("Solid", typeof (SolidType))]
    public AbstractSolidType[] Items
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