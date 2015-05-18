namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("boundedBy", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = true)]
  public partial class BoundingShapeType
  {

    private object itemField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof (EnvelopeType))]
    [System.Xml.Serialization.XmlElementAttribute("EnvelopeWithTimePeriod", typeof (EnvelopeWithTimePeriodType))]
    [System.Xml.Serialization.XmlElementAttribute("Null", typeof (string))]
    public object Item
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
  }
}