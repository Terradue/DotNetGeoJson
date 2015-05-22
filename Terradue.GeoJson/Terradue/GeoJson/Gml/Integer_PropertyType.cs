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
  public class Integer_PropertyType
  {
    private string integerField;
    private string nilReasonField;

    [XmlElement(DataType = "integer")]
    public string Integer
    {
      get { return integerField; }
      set { integerField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}