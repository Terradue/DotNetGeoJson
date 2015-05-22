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
  public class DQ_NonQuantitativeAttributeAccuracy_PropertyType
  {
    private DQ_NonQuantitativeAttributeAccuracy_Type dQ_NonQuantitativeAttributeAccuracyField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public DQ_NonQuantitativeAttributeAccuracy_Type DQ_NonQuantitativeAttributeAccuracy
    {
      get { return dQ_NonQuantitativeAttributeAccuracyField; }
      set { dQ_NonQuantitativeAttributeAccuracyField = value; }
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