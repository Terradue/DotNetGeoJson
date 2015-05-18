namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ImageCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ImageCRSType : AbstractCRSType
  {

    private object itemField;

    private ItemChoiceType7 itemElementNameField;

    private ImageDatumPropertyType item1Field;

    private Item1ChoiceType4 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("affineCS", typeof (AffineCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesAffineCS", typeof (AffineCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesObliqueCartesianCS", typeof (ObliqueCartesianCSPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType7 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("imageDatum", typeof (ImageDatumPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesImageDatum", typeof (ImageDatumPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public ImageDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType4 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}