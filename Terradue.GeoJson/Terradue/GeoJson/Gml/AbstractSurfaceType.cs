namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OrientableSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TinType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PolygonType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractSurfaceType : AbstractGeometricPrimitiveType
  {
  }
}