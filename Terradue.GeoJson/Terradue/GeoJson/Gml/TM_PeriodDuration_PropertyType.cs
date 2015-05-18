namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gts")]
  public partial class TM_PeriodDuration_PropertyType
  {

    private string tM_PeriodDurationField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
    public string TM_PeriodDuration
    {
      get { return tM_PeriodDurationField; }
      set { tM_PeriodDurationField = value; }
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