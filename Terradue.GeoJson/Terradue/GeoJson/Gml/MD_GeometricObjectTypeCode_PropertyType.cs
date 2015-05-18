namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_GeometricObjectTypeCode_PropertyType
  {

    private CodeListValue_Type mD_GeometricObjectTypeCodeField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeListValue_Type MD_GeometricObjectTypeCode
    {
      get { return mD_GeometricObjectTypeCodeField; }
      set { mD_GeometricObjectTypeCodeField = value; }
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