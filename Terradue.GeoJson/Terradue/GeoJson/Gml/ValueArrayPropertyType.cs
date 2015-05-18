namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("valueComponents", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ValueArrayPropertyType
  {

    private object[] itemsField;

    private ItemsChoiceType21[] itemsElementNameField;

    private bool ownsField;

    public ValueArrayPropertyType()
    {
      ownsField = false;
    }

    [System.Xml.Serialization.XmlElementAttribute("AbstractGeometry", typeof (AbstractGeometryType))]
    [System.Xml.Serialization.XmlElementAttribute("AbstractTimeObject", typeof (AbstractTimeObjectType))]
    [System.Xml.Serialization.XmlElementAttribute("AbstractValue", typeof (object))]
    [System.Xml.Serialization.XmlElementAttribute("CategoryExtent", typeof (CategoryExtentType))]
    [System.Xml.Serialization.XmlElementAttribute("CompositeValue", typeof (CompositeValueType))]
    [System.Xml.Serialization.XmlElementAttribute("CountExtent", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("GeometricComplex", typeof (GeometricComplexType))]
    [System.Xml.Serialization.XmlElementAttribute("Null", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("QuantityExtent", typeof (QuantityExtentType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType21[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}