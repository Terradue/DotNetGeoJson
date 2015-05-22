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
  [XmlRoot("multiCenterLineOf", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class MultiCurvePropertyType
  {
    private MultiCurveType multiCurveField;
    private string nilReasonField;
    private bool ownsField;
    private string remoteSchemaField;

    public MultiCurvePropertyType()
    {
      ownsField = false;
    }

    [XmlElement]
    public MultiCurveType MultiCurve
    {
      get { return multiCurveField; }
      set { multiCurveField = value; }
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