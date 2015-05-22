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
  public class DQ_EvaluationMethodTypeCode_PropertyType
  {
    private CodeListValue_Type dQ_EvaluationMethodTypeCodeField;
    private string nilReasonField;

    [XmlElement]
    public CodeListValue_Type DQ_EvaluationMethodTypeCode
    {
      get { return dQ_EvaluationMethodTypeCodeField; }
      set { dQ_EvaluationMethodTypeCodeField = value; }
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