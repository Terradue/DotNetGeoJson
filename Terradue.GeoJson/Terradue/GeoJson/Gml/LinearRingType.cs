namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("LinearRing", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class LinearRingType : AbstractRingType
  {

    private object[] itemsField;

    private ItemsChoiceType6[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof (CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof (DirectPositionListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType6[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}