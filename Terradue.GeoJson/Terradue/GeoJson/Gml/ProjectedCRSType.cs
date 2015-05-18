namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType
  {

    private object item1Field;

    private CartesianCSPropertyType item2Field;

    private Item2ChoiceType1 item2ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("baseGeodeticCRS", typeof (GeodeticCRSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("baseGeographicCRS", typeof (GeographicCRSPropertyType))]
    public object Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("cartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesCartesianCS", typeof (CartesianCSPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
    public CartesianCSPropertyType Item2
    {
      get { return item2Field; }
      set { item2Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item2ChoiceType1 Item2ElementName
    {
      get { return item2ElementNameField; }
      set { item2ElementNameField = value; }
    }
  }
}