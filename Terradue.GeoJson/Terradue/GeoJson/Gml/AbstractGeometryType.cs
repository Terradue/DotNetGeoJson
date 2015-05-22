using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (GridType))]
  [XmlInclude(typeof (RectifiedGridType))]
  [XmlInclude(typeof (GeometricComplexType))]
  [XmlInclude(typeof (AbstractGeometricAggregateType))]
  [XmlInclude(typeof (MultiSolidType))]
  [XmlInclude(typeof (MultiSurfaceType))]
  [XmlInclude(typeof (MultiCurveType))]
  [XmlInclude(typeof (MultiPointType))]
  [XmlInclude(typeof (MultiGeometryType))]
  [XmlInclude(typeof (AbstractGeometricPrimitiveType))]
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
  [XmlRoot("AbstractGeometry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractGeometryType : AbstractGMLType
  {
    private string srsDimensionField;
    private string srsNameField;

    [XmlAttribute(DataType = "anyURI")]
    public string srsName
    {
      get { return srsNameField; }
      set { srsNameField = value; }
    }

    [XmlAttribute(DataType = "positiveInteger")]
    public string srsDimension
    {
      get { return srsDimensionField; }
      set { srsDimensionField = value; }
    }
  }
}