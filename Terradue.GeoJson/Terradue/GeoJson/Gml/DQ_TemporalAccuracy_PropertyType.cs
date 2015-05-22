using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class DQ_TemporalAccuracy_PropertyType
  {
    private AbstractDQ_TemporalAccuracy_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("DQ_AccuracyOfATimeMeasurement",
      typeof (DQ_AccuracyOfATimeMeasurement_Type))]
    [XmlElement("DQ_TemporalConsistency", typeof (DQ_TemporalConsistency_Type))]
    [XmlElement("DQ_TemporalValidity", typeof (DQ_TemporalValidity_Type))]
    public AbstractDQ_TemporalAccuracy_Type Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute]
    public string uuidref
    {
      get { return uuidrefField; }
      set { uuidrefField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}