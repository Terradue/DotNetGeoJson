namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("datumRef", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class DatumPropertyType
  {

    private AbstractDatumType itemField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute("EngineeringDatum", typeof (EngineeringDatumType))]
    [System.Xml.Serialization.XmlElementAttribute("GeodeticDatum", typeof (GeodeticDatumType))]
    [System.Xml.Serialization.XmlElementAttribute("ImageDatum", typeof (ImageDatumType))]
    [System.Xml.Serialization.XmlElementAttribute("TemporalDatum", typeof (TemporalDatumType))]
    [System.Xml.Serialization.XmlElementAttribute("VerticalDatum", typeof (VerticalDatumType))]
    public AbstractDatumType Item
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