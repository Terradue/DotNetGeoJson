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
  public class DQ_Result_PropertyType
  {
    private AbstractDQ_Result_Type itemField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement("DQ_ConformanceResult", typeof (DQ_ConformanceResult_Type))]
    [XmlElement("DQ_QuantitativeResult", typeof (DQ_QuantitativeResult_Type))]
    public AbstractDQ_Result_Type Item
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