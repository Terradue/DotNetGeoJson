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
  [XmlRoot("subComplex", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoComplexPropertyType
  {
    private string nilReasonField;
    private string remoteSchemaField;
    private TopoComplexType topoComplexField;

    [XmlElement]
    public TopoComplexType TopoComplex
    {
      get { return topoComplexField; }
      set { topoComplexField = value; }
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