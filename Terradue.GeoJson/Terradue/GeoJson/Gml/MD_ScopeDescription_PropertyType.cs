namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_ScopeDescription_PropertyType
  {

    private MD_ScopeDescription_Type mD_ScopeDescriptionField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public MD_ScopeDescription_Type MD_ScopeDescription
    {
      get { return mD_ScopeDescriptionField; }
      set { mD_ScopeDescriptionField = value; }
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