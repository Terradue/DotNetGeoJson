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
  [XmlRoot("EnvelopeWithTimePeriod", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class EnvelopeWithTimePeriodType : EnvelopeType
  {
    private TimePositionType beginPositionField;
    private TimePositionType endPositionField;
    private string frameField;

    public EnvelopeWithTimePeriodType()
    {
      frameField = "#ISO-8601";
    }

    [XmlElement]
    public TimePositionType beginPosition
    {
      get { return beginPositionField; }
      set { beginPositionField = value; }
    }

    [XmlElement]
    public TimePositionType endPosition
    {
      get { return endPositionField; }
      set { endPositionField = value; }
    }

    [XmlAttribute(DataType = "anyURI")]
    [DefaultValue("#ISO-8601")]
    public string frame
    {
      get { return frameField; }
      set { frameField = value; }
    }
  }
}