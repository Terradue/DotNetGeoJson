namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Conversion", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ConversionType : AbstractGeneralConversionType
  {

    private OperationMethodPropertyType itemField;

    private ItemChoiceType11 itemElementNameField;

    private AbstractGeneralParameterValuePropertyType[] itemsField;

    private ItemsChoiceType15[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("method", typeof (OperationMethodPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesMethod", typeof (OperationMethodPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public OperationMethodPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType11 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("includesValue", typeof (AbstractGeneralParameterValuePropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("parameterValue", typeof (AbstractGeneralParameterValuePropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("usesValue", typeof (AbstractGeneralParameterValuePropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public AbstractGeneralParameterValuePropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType15[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}