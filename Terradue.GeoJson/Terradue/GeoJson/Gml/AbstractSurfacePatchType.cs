using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractParametricCurveSurfaceType))]
  [XmlInclude(typeof (AbstractGriddedSurfaceType))]
  [XmlInclude(typeof (SphereType))]
  [XmlInclude(typeof (CylinderType))]
  [XmlInclude(typeof (ConeType))]
  [XmlInclude(typeof (RectangleType))]
  [XmlInclude(typeof (TriangleType))]
  [XmlInclude(typeof (PolygonPatchType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractSurfacePatch", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractSurfacePatchType
  {
  }
}