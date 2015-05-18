namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ObligationCode_PropertyType
  {

    private MD_ObligationCode_Type mD_ObligationCodeField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ObligationCode_Type MD_ObligationCode
    {
      get { return mD_ObligationCodeField; }
      set { mD_ObligationCodeField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}