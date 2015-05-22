using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (AbstractSolidType))]
  [XmlInclude(typeof (CompositeSolidType))]
  [XmlInclude(typeof (SolidType))]
  [XmlInclude(typeof (AbstractSurfaceType))]
  [XmlInclude(typeof (CompositeSurfaceType))]
  [XmlInclude(typeof (OrientableSurfaceType))]
  [XmlInclude(typeof (SurfaceType))]
  [XmlInclude(typeof (TinType))]
  [XmlInclude(typeof (PolygonType))]
  [XmlInclude(typeof (AbstractCurveType))]
  [XmlInclude(typeof (CompositeCurveType))]
  [XmlInclude(typeof (OrientableCurveType))]
  [XmlInclude(typeof (CurveType))]
  [XmlInclude(typeof (LineStringType))]
  [XmlInclude(typeof (PointType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractGeometricPrimitive", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractGeometricPrimitiveType : AbstractGeometryType
  {
  }
}