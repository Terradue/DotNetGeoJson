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
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class TimeTopologyComplexPropertyType
  {
    private string nilReasonField;
    private bool ownsField;
    private string remoteSchemaField;
    private TimeTopologyComplexType timeTopologyComplexField;

    public TimeTopologyComplexPropertyType()
    {
      ownsField = false;
    }

    [XmlElement]
    public TimeTopologyComplexType TimeTopologyComplex
    {
      get { return timeTopologyComplexField; }
      set { timeTopologyComplexField = value; }
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

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}