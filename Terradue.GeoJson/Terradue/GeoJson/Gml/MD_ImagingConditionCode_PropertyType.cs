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
  public class MD_ImagingConditionCode_PropertyType
  {
    private CodeListValue_Type mD_ImagingConditionCodeField;
    private string nilReasonField;

    [XmlElement]
    public CodeListValue_Type MD_ImagingConditionCode
    {
      get { return mD_ImagingConditionCodeField; }
      set { mD_ImagingConditionCodeField = value; }
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