using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (CompositeSurfaceType))]
  [XmlInclude(typeof (OrientableSurfaceType))]
  [XmlInclude(typeof (SurfaceType))]
  [XmlInclude(typeof (TinType))]
  [XmlInclude(typeof (PolygonType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractSurface", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractSurfaceType : AbstractGeometricPrimitiveType
  {
  }
}