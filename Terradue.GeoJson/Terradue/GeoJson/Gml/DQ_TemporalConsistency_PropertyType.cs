namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_TemporalConsistency_PropertyType
  {

    private DQ_TemporalConsistency_Type dQ_TemporalConsistencyField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DQ_TemporalConsistency_Type DQ_TemporalConsistency
    {
      get { return dQ_TemporalConsistencyField; }
      set { dQ_TemporalConsistencyField = value; }
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