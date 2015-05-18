namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ScopeDescription_Type
  {

    private object[] itemsField;

    private ItemsChoiceType10[] itemsElementNameField;

    [System.Xml.Serialization.XmlElementAttribute("attributeInstances", typeof (ObjectReference_PropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("attributes", typeof (ObjectReference_PropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("dataset", typeof (CharacterString_PropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("featureInstances", typeof (ObjectReference_PropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("features", typeof (ObjectReference_PropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("other", typeof (CharacterString_PropertyType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType10[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }
  }
}