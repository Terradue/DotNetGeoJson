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
  public class DQ_CompletenessCommission_PropertyType
  {
    private DQ_CompletenessCommission_Type dQ_CompletenessCommissionField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public DQ_CompletenessCommission_Type DQ_CompletenessCommission
    {
      get { return dQ_CompletenessCommissionField; }
      set { dQ_CompletenessCommissionField = value; }
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