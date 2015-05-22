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
  public class UnlimitedInteger_PropertyType
  {
    private string nilReasonField;
    private UnlimitedInteger_Type unlimitedIntegerField;

    [XmlElement(IsNullable = true)]
    public UnlimitedInteger_Type UnlimitedInteger
    {
      get { return unlimitedIntegerField; }
      set { unlimitedIntegerField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}