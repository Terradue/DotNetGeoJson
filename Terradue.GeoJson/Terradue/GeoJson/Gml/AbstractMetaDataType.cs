using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (GenericMetaDataType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractMetaData", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractMetaDataType
  {
    private string idField;
    private string[] textField;

    [XmlText]
    public string[] Text
    {
      get { return textField; }
      set { textField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "ID")]
    public string id
    {
      get { return idField; }
      set { idField = value; }
    }
  }
}