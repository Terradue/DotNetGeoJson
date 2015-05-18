namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("EnvelopeWithTimePeriod", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class EnvelopeWithTimePeriodType : EnvelopeType
  {

    private TimePositionType beginPositionField;

    private TimePositionType endPositionField;

    private string frameField;

    public EnvelopeWithTimePeriodType()
    {
      frameField = "#ISO-8601";
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePositionType beginPosition
    {
      get { return beginPositionField; }
      set { beginPositionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute()]
    public TimePositionType endPosition
    {
      get { return endPositionField; }
      set { endPositionField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
    public string frame
    {
      get { return frameField; }
      set { frameField = value; }
    }
  }
}