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
  [XmlType(Namespace = "http://www.isotc211.org/2005/gts")]
  public class TM_PeriodDuration_PropertyType
  {
    private string nilReasonField;
    private string tM_PeriodDurationField;

    [XmlElement(DataType = "duration")]
    public string TM_PeriodDuration
    {
      get { return tM_PeriodDurationField; }
      set { tM_PeriodDurationField = value; }
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