using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("boundedBy", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = true)]
  public class BoundingShapeType
  {
    private object itemField;
    private string nilReasonField;

    [XmlElement("Envelope", typeof (EnvelopeType))]
    [XmlElement("EnvelopeWithTimePeriod", typeof (EnvelopeWithTimePeriodType))]
    [XmlElement("Null", typeof (string))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}