namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("OperationParameterGroup", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class OperationParameterGroupType : AbstractGeneralOperationParameterType
  {

    private string maximumOccursField;

    private AbstractGeneralOperationParameterPropertyType[] itemsField;

    private ItemsChoiceType11[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
    public string maximumOccurs
    {
      get { return maximumOccursField; }
      set { maximumOccursField = value; }
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
    public ItemsChoiceType11[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}