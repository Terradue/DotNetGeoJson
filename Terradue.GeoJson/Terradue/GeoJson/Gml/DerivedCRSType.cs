namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("DerivedCRS", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DerivedCRSType : AbstractGeneralDerivedCRSType
  {

    private SingleCRSPropertyType baseCRSField;

    private CodeWithAuthorityType derivedCRSTypeField;

    private CoordinateSystemPropertyType item1Field;

    private Item1ChoiceType7 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public SingleCRSPropertyType baseCRS
    {
      get { return baseCRSField; }
      set { baseCRSField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeWithAuthorityType derivedCRSType
    {
      get { return derivedCRSTypeField; }
      set { derivedCRSTypeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("coordinateSystem", typeof (CoordinateSystemPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesCS", typeof (CoordinateSystemPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public CoordinateSystemPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType7 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}