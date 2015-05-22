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
  [XmlRoot("directedTopoSolid", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class DirectedTopoSolidPropertyType
  {
    private string nilReasonField;
    private SignType orientationField;
    private bool ownsField;
    private string remoteSchemaField;
    private TopoSolidType topoSolidField;

    public DirectedTopoSolidPropertyType()
    {
      orientationField = SignType.Item1;
      ownsField = false;
    }

    [XmlElement]
    public TopoSolidType TopoSolid
    {
      get { return topoSolidField; }
      set { topoSolidField = value; }
    }

    [XmlAttribute]
    [DefaultValue(SignType.Item1)]
    public SignType orientation
    {
      get { return orientationField; }
      set { orientationField = value; }
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