namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("GeodeticDatum", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class GeodeticDatumType : AbstractDatumType
  {

    private PrimeMeridianPropertyType item1Field;

    private Item1ChoiceType item1ElementNameField;

    private EllipsoidPropertyType item2Field;

    private Item2ChoiceType item2ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("primeMeridian", typeof (PrimeMeridianPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesPrimeMeridian", typeof (PrimeMeridianPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public PrimeMeridianPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ellipsoid", typeof (EllipsoidPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesEllipsoid", typeof (EllipsoidPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item2ElementName")]
    public EllipsoidPropertyType Item2
    {
      get { return item2Field; }
      set { item2Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item2ChoiceType Item2ElementName
    {
      get { return item2ElementNameField; }
      set { item2ElementNameField = value; }
    }
  }
}