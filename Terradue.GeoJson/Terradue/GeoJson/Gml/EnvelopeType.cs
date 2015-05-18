namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EnvelopeWithTimePeriodType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Envelope", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class EnvelopeType
  {

    private object[] itemsField;

    private ItemsChoiceType19[] itemsElementNameField;

    private string srsNameField;

    private string srsDimensionField;

    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof (CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("lowerCorner", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("upperCorner", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType19[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string srsName
    {
      get { return srsNameField; }
      set { srsNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
    public string srsDimension
    {
      get { return srsDimensionField; }
      set { srsDimensionField = value; }
    }
  }
}