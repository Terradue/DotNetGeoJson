namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("OperationMethod", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class OperationMethodType : IdentifiedObjectType
  {

    private object itemField;

    private ItemChoiceType10 itemElementNameField;

    private string sourceDimensionsField;

    private string targetDimensionsField;

    private AbstractGeneralOperationParameterPropertyType[] itemsField;

    private ItemsChoiceType12[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("formula", typeof (CodeType))]
    [System.Xml.Serialization.XmlElementAttribute("formulaCitation", typeof (formulaCitation))]
    [System.Xml.Serialization.XmlElementAttribute("methodFormula", typeof (CodeType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType10 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
    public string sourceDimensions
    {
      get { return sourceDimensionsField; }
      set { sourceDimensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
    public string targetDimensions
    {
      get { return targetDimensionsField; }
      set { targetDimensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("generalOperationParameter",
      typeof (AbstractGeneralOperationParameterPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("includesParameter",
      typeof (AbstractGeneralOperationParameterPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("parameter", typeof (AbstractGeneralOperationParameterPropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public AbstractGeneralOperationParameterPropertyType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType12[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}