namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_TemporalValidity_PropertyType
  {

    private DQ_TemporalValidity_Type dQ_TemporalValidityField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public DQ_TemporalValidity_Type DQ_TemporalValidity
    {
      get { return dQ_TemporalValidityField; }
      set { dQ_TemporalValidityField = value; }
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