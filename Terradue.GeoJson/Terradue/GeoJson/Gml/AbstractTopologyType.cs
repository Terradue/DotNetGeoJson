namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoVolumeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTopoPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TopoSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (EdgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (FaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (NodeType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractTopology", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractTopologyType : AbstractGMLType
  {
  }
}