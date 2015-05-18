namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
  public partial class UnlimitedInteger_PropertyType
  {

    private UnlimitedInteger_Type unlimitedIntegerField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public UnlimitedInteger_Type UnlimitedInteger
    {
      get { return unlimitedIntegerField; }
      set { unlimitedIntegerField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}