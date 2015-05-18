namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_ThematicAccuracy_PropertyType
  {

    private AbstractDQ_ThematicAccuracy_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("DQ_NonQuantitativeAttributeAccuracy",
      typeof (DQ_NonQuantitativeAttributeAccuracy_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_QuantitativeAttributeAccuracy",
      typeof (DQ_QuantitativeAttributeAccuracy_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_ThematicClassificationCorrectness",
      typeof (DQ_ThematicClassificationCorrectness_Type))]
    public AbstractDQ_ThematicAccuracy_Type Item
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