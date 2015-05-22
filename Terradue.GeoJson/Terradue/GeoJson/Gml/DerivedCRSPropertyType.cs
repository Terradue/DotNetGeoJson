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
  [XmlRoot("derivedCRSRef", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DerivedCRSPropertyType
  {
    private DerivedCRSType derivedCRSField;
    private string nilReasonField;
    private string remoteSchemaField;

    [XmlElement]
    public DerivedCRSType DerivedCRS
    {
      get { return derivedCRSField; }
      set { derivedCRSField = value; }
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