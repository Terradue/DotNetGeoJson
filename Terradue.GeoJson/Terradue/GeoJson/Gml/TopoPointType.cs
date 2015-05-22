using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("TopoPoint", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class TopoPointType : AbstractTopologyType
  {
    private DirectedNodePropertyType directedNodeField;

    [XmlElement]
    public DirectedNodePropertyType directedNode
    {
      get { return directedNodeField; }
      set { directedNodeField = value; }
    }
  }
}