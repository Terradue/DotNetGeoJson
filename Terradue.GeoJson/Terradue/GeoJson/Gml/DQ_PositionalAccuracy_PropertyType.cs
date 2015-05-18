namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class DQ_PositionalAccuracy_PropertyType
  {

    private AbstractDQ_PositionalAccuracy_Type itemField;

    private string uuidrefField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("DQ_AbsoluteExternalPositionalAccuracy",
      typeof (DQ_AbsoluteExternalPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_GriddedDataPositionalAccuracy",
      typeof (DQ_GriddedDataPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlElementAttribute("DQ_RelativeInternalPositionalAccuracy",
      typeof (DQ_RelativeInternalPositionalAccuracy_Type))]
    public AbstractDQ_PositionalAccuracy_Type Item
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