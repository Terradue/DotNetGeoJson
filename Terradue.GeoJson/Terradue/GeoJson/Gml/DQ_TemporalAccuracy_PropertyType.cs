namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_TemporalAccuracy_PropertyType
  {

    private AbstractDQ_TemporalAccuracy_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("DQ_AccuracyOfATimeMeasurement",
      typeof (DQ_AccuracyOfATimeMeasurement_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_TemporalConsistency", typeof (DQ_TemporalConsistency_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_TemporalValidity", typeof (DQ_TemporalValidity_Type))]
    public AbstractDQ_TemporalAccuracy_Type Item
    {
      get { return itemField; }
      set { itemField = value; }
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