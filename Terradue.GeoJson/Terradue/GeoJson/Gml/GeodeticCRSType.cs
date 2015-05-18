namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("GeodeticCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GeodeticCRSType : AbstractCRSType
  {

    private object itemField;

    private ItemChoiceType3 itemElementNameField;

    private GeodeticDatumPropertyType item1Field;

    private Item1ChoiceType1 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("ellipsoidalCS", typeof (EllipsoidalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("sphericalCS", typeof (SphericalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesEllipsoidalCS", typeof (EllipsoidalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesSphericalCS", typeof (SphericalCSPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType3 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("geodeticDatum", typeof (GeodeticDatumPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesGeodeticDatum", typeof (GeodeticDatumPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public GeodeticDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType1 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}