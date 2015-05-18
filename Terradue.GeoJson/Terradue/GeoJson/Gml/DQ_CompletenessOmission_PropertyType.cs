namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_CompletenessOmission_PropertyType
  {

    private DQ_CompletenessOmission_Type dQ_CompletenessOmissionField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DQ_CompletenessOmission_Type DQ_CompletenessOmission
    {
      get { return dQ_CompletenessOmissionField; }
      set { dQ_CompletenessOmissionField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uuidref
    {
      get { return uuidrefField; }
      set { uuidrefField = value; }
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