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
  [XmlRoot("metaDataProperty", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MetaDataPropertyType
  {
    private string aboutField;
    private GenericMetaDataType itemField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement("GenericMetaData")]
    public GenericMetaDataType Item
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

    [XmlAttribute(DataType = "anyURI")]
    public string about
    {
      get { return aboutField; }
      set { aboutField = value; }
    }
  }
}