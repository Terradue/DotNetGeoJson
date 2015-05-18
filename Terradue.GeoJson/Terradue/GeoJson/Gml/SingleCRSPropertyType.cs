namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("componentReferenceSystem", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class SingleCRSPropertyType
  {

    private AbstractCRSType itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("EngineeringCRS", typeof (EngineeringCRSType))]
    [System.Xml.Serialization.XmlElementAttribute("GeocentricCRS", typeof (GeocentricCRSType))]
    [System.Xml.Serialization.XmlElementAttribute("GeodeticCRS", typeof (GeodeticCRSType))]
    [System.Xml.Serialization.XmlElementAttribute("GeographicCRS", typeof (GeographicCRSType))]
    [System.Xml.Serialization.XmlElementAttribute("ImageCRS", typeof (ImageCRSType))]
    [System.Xml.Serialization.XmlElementAttribute("TemporalCRS", typeof (TemporalCRSType))]
    [System.Xml.Serialization.XmlElementAttribute("VerticalCRS", typeof (VerticalCRSType))]
    public AbstractCRSType Item
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