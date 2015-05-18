namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("VerticalCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class VerticalCRSType : AbstractCRSType
  {

    private VerticalCSPropertyType itemField;

    private ItemChoiceType5 itemElementNameField;

    private VerticalDatumPropertyType item1Field;

    private Item1ChoiceType2 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("usesVerticalCS", typeof (VerticalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("verticalCS", typeof (VerticalCSPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public VerticalCSPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType5 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("usesVerticalDatum", typeof (VerticalDatumPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("verticalDatum", typeof (VerticalDatumPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public VerticalDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType2 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}