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
  [XmlRoot("topoPrimitiveMember", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoPrimitiveMemberType
  {
    private AbstractTopoPrimitiveType itemField;
    private string nilReasonField;
    private bool ownsField;
    private string remoteSchemaField;

    public TopoPrimitiveMemberType()
    {
      ownsField = false;
    }

    [XmlElement("Edge", typeof (EdgeType))]
    [XmlElement("Face", typeof (FaceType))]
    [XmlElement("Node", typeof (NodeType))]
    [XmlElement("TopoSolid", typeof (TopoSolidType))]
    public AbstractTopoPrimitiveType Item
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

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}