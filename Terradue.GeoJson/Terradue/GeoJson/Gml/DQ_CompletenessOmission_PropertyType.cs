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
  public class DQ_CompletenessOmission_PropertyType
  {
    private DQ_CompletenessOmission_Type dQ_CompletenessOmissionField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public DQ_CompletenessOmission_Type DQ_CompletenessOmission
    {
      get { return dQ_CompletenessOmissionField; }
      set { dQ_CompletenessOmissionField = value; }
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