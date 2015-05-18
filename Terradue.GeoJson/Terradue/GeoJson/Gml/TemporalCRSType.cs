namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("TemporalCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TemporalCRSType : AbstractCRSType
  {

    private object itemField;

    private ItemChoiceType8 itemElementNameField;

    private TemporalDatumPropertyType item1Field;

    private Item1ChoiceType5 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("timeCS", typeof (TimeCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesTemporalCS", typeof (TemporalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesTimeCS", typeof (TimeCSPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType8 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("temporalDatum", typeof (TemporalDatumPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesTemporalDatum", typeof (TemporalDatumPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public TemporalDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType5 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}