namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class GenericName_PropertyType
  {

    private CodeType itemField;

    private ItemChoiceType9 itemElementNameField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("LocalName", typeof (CodeType))]
    [System.Xml.Serialization.XmlElementAttribute("ScopedName", typeof (CodeType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public CodeType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType9 ItemElementName
    {
      get { return itemElementNameField; }
      set { itemElementNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}