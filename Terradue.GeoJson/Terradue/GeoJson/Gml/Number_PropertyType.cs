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
  public class Number_PropertyType
  {
    private object itemField;
    private string nilReasonField;

    [XmlElement("Decimal", typeof (decimal))]
    [XmlElement("Integer", typeof (string), DataType = "integer")]
    [XmlElement("Real", typeof (double))]
    public object Item
    {
      get { return itemField; }
      set { itemField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified)]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}