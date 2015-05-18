namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class coordinateOperationAccuracy
  {

    private AbstractDQ_PositionalAccuracy_Type itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("DQ_AbsoluteExternalPositionalAccuracy",
      typeof (DQ_AbsoluteExternalPositionalAccuracy_Type), Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlElementAttribute("DQ_GriddedDataPositionalAccuracy",
      typeof (DQ_GriddedDataPositionalAccuracy_Type), Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlElementAttribute("DQ_RelativeInternalPositionalAccuracy",
      typeof (DQ_RelativeInternalPositionalAccuracy_Type), Namespace = "http://www.isotc211.org/2005/gmd")]
    public AbstractDQ_PositionalAccuracy_Type Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}