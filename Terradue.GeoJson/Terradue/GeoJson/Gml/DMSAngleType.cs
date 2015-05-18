namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("dmsAngleValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DMSAngleType
  {

    private DegreesType degreesField;

    private object[] itemsField;

    private ItemsChoiceType13[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DegreesType degrees
    {
      get { return degreesField; }
      set { degreesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("decimalMinutes", typeof (decimal))]
    [System.Xml.Serialization.XmlElementAttribute("minutes", typeof (string), DataType = "nonNegativeInteger")]
    [System.Xml.Serialization.XmlElementAttribute("seconds", typeof (decimal))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType13[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}