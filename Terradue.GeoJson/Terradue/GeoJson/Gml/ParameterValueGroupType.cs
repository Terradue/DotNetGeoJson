namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ParameterValueGroup", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ParameterValueGroupType : AbstractGeneralParameterValueType
  {

    private AbstractGeneralParameterValuePropertyType[] itemsField;

    private ItemsChoiceType14[] itemsElementNameField;

    private OperationParameterGroupPropertyType itemField;

    private ItemChoiceType13 itemElementNameField;

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
    public ItemsChoiceType14[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("group", typeof (OperationParameterGroupPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("valuesOfGroup", typeof (OperationParameterGroupPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public OperationParameterGroupPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType13 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }
  }
}