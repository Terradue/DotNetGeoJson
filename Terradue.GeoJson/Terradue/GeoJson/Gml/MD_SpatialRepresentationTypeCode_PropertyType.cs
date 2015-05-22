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
  public class MD_SpatialRepresentationTypeCode_PropertyType
  {
    private CodeListValue_Type mD_SpatialRepresentationTypeCodeField;
    private string nilReasonField;

    [XmlElement]
    public CodeListValue_Type MD_SpatialRepresentationTypeCode
    {
      get { return mD_SpatialRepresentationTypeCodeField; }
      set { mD_SpatialRepresentationTypeCodeField = value; }
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