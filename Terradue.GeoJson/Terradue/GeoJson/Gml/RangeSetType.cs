namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("rangeSet", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class RangeSetType
  {

    private object[] itemsField;

    private ItemsChoiceType22[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("AbstractScalarValueList", typeof (object))]
    [System.Xml.Serialization.XmlElementAttribute("BooleanList", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("CategoryList", typeof (CodeOrNilReasonListType))]
    [System.Xml.Serialization.XmlElementAttribute("CountList", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("DataBlock", typeof (DataBlockType))]
    [System.Xml.Serialization.XmlElementAttribute("File", typeof (FileType))]
    [System.Xml.Serialization.XmlElementAttribute("QuantityList", typeof (MeasureOrNilReasonListType))]
    [System.Xml.Serialization.XmlElementAttribute("ValueArray", typeof (ValueArrayType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType22[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}