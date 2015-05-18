namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class Number_PropertyType
  {

    private object itemField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("Decimal", typeof (decimal))]
    [System.Xml.Serialization.XmlElementAttribute("Integer", typeof (string), DataType = "integer")]
    [System.Xml.Serialization.XmlElementAttribute("Real", typeof (double))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}