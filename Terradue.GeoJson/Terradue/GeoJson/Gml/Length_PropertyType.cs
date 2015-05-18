namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class Length_PropertyType
  {

    private LengthType itemField;

    private ItemChoiceType19 itemElementNameField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("Distance", typeof (LengthType))]
    [System.Xml.Serialization.XmlElementAttribute("Length", typeof (LengthType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public LengthType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType19 ItemElementName
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