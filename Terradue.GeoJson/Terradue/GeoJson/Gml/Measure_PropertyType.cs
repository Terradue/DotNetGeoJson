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
  [XmlType(Namespace = "http://www.isotc211.org/2005/gco")]
  public class Measure_PropertyType
  {
    private MeasureType itemField;
    private string nilReasonField;

    [XmlElement("Angle", typeof (AngleType))]
    [XmlElement("Length", typeof (LengthType))]
    [XmlElement("Measure", typeof (MeasureType))]
    [XmlElement("Scale", typeof (ScaleType))]
    public MeasureType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}