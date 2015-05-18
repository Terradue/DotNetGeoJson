namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_LogicalConsistency_PropertyType
  {

    private AbstractDQ_LogicalConsistency_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("DQ_ConceptualConsistency", typeof (DQ_ConceptualConsistency_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_DomainConsistency", typeof (DQ_DomainConsistency_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_FormatConsistency", typeof (DQ_FormatConsistency_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_TopologicalConsistency", typeof (DQ_TopologicalConsistency_Type))]
    public AbstractDQ_LogicalConsistency_Type Item
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