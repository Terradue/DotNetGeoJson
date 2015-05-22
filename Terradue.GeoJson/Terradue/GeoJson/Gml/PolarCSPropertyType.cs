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
  [XmlRoot("polarCS", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false
    )]
  public class PolarCSPropertyType
  {
    private string nilReasonField;
    private PolarCSType polarCSField;
    private string remoteSchemaField;

    [XmlElement]
    public PolarCSType PolarCS
    {
      get { return polarCSField; }
      set { polarCSField = value; }
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