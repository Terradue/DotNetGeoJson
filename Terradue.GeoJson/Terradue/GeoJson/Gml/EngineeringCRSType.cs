namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("EngineeringCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class EngineeringCRSType : AbstractCRSType
  {

    private object itemField;

    private ItemChoiceType6 itemElementNameField;

    private EngineeringDatumPropertyType item1Field;

    private Item1ChoiceType3 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("affineCS", typeof (AffineCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("coordinateSystem", typeof (CoordinateSystemPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("cylindricalCS", typeof (CylindricalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("linearCS", typeof (LinearCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("polarCS", typeof (PolarCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("sphericalCS", typeof (SphericalCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("userDefinedCS", typeof (UserDefinedCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesAffineCS", typeof (AffineCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesCS", typeof (CoordinateSystemPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesSphericalCS", typeof (SphericalCSPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType6 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("engineeringDatum", typeof (EngineeringDatumPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesEngineeringDatum", typeof (EngineeringDatumPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public EngineeringDatumPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType3 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}