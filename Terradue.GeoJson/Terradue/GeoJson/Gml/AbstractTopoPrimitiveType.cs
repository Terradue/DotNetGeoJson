using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (TopoSolidType))]
  [XmlInclude(typeof (EdgeType))]
  [XmlInclude(typeof (FaceType))]
  [XmlInclude(typeof (NodeType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractTopoPrimitive", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractTopoPrimitiveType : AbstractTopologyType
  {
  }
}