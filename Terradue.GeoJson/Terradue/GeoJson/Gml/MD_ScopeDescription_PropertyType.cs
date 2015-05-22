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
  public class MD_ScopeDescription_PropertyType
  {
    private MD_ScopeDescription_Type mD_ScopeDescriptionField;
    private string nilReasonField;

    [XmlElement]
    public MD_ScopeDescription_Type MD_ScopeDescription
    {
      get { return mD_ScopeDescriptionField; }
      set { mD_ScopeDescriptionField = value; }
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