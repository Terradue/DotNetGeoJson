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
  [XmlRoot("parameter", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class AbstractGeneralOperationParameterPropertyType
  {
    private AbstractGeneralOperationParameterType itemField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement("OperationParameter", typeof (OperationParameterType))]
    [XmlElement("OperationParameterGroup", typeof (OperationParameterGroupType))]
    public AbstractGeneralOperationParameterType Item
    {
      get { return itemField; }
      set { itemField = value; }
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