namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ObliqueCartesianCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TemporalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AffineCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CylindricalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PolarCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SphericalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (UserDefinedCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LinearCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (VerticalCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CartesianCSType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EllipsoidalCSType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractCoordinateSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractCoordinateSystemType : IdentifiedObjectType
  {

    private CoordinateSystemAxisPropertyType[] itemsField;

    private ItemsChoiceType8[] itemsElementNameField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("axis", typeof (CoordinateSystemAxisPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesAxis", typeof (CoordinateSystemAxisPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public CoordinateSystemAxisPropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType8[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}