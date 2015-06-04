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
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("method", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)
  ]
  public class OperationMethodPropertyType
  {
    private string nilReasonField;
    private OperationMethodType operationMethodField;
    private string remoteSchemaField;

    [XmlElement]
    public OperationMethodType OperationMethod
    {
      get { return operationMethodField; }
      set { operationMethodField = value; }
    }

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}