namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Transformation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class TransformationType : AbstractGeneralTransformationType
  {

    private OperationMethodPropertyType itemField;

    private ItemChoiceType14 itemElementNameField;

    private AbstractGeneralParameterValuePropertyType[] itemsField;

    private ItemsChoiceType16[] itemsElementNameField;

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
    public ItemChoiceType14 ItemElementName
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
    public ItemsChoiceType16[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}