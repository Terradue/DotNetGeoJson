using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (PriorityLocationPropertyType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("location", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class LocationPropertyType
  {
    private object itemField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement("AbstractGeometry", typeof (AbstractGeometryType))]
    [XmlElement("GeometricComplex", typeof (GeometricComplexType))]
    [XmlElement("LocationKeyWord", typeof (CodeType))]
    [XmlElement("LocationString", typeof (StringOrRefType))]
    [XmlElement("Null", typeof (string))]
    public object Item
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