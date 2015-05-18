namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ParameterValue", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ParameterValueType : AbstractGeneralParameterValueType
  {

    private object itemField;

    private ItemChoiceType12 itemElementNameField;

    private OperationParameterPropertyType item1Field;

    private Item1ChoiceType6 item1ElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("booleanValue", typeof (bool))]
    [System.Xml.Serialization.XmlElementAttribute("dmsAngleValue", typeof (DMSAngleType))]
    [System.Xml.Serialization.XmlElementAttribute("integerValue", typeof (string), DataType = "positiveInteger")]
    [System.Xml.Serialization.XmlElementAttribute("integerValueList", typeof (string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("stringValue", typeof (string))]
    [System.Xml.Serialization.XmlElementAttribute("value", typeof (MeasureType))]
    [System.Xml.Serialization.XmlElementAttribute("valueFile", typeof (string), DataType = "anyURI")]
    [System.Xml.Serialization.XmlElementAttribute("valueList", typeof (MeasureListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType12 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("operationParameter", typeof (OperationParameterPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("valueOfParameter", typeof (OperationParameterPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
    public OperationParameterPropertyType Item1
    {
      get { return item1Field; }
      set { item1Field = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public Item1ChoiceType6 Item1ElementName
    {
      get { return item1ElementNameField; }
      set { item1ElementNameField = value; }
    }
  }
}