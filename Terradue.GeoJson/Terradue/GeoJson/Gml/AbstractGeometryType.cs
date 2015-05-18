namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GridType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (RectifiedGridType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (GeometricComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeometricAggregateType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiGeometryType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractGeometricPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OrientableSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (SurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TinType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PolygonType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OrientableCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LineStringType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (PointType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractGeometry", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractGeometryType : AbstractGMLType
  {

    private string srsNameField;

    private string srsDimensionField;

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string srsName
    {
      get { return srsNameField; }
      set { srsNameField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
    public string srsDimension
    {
      get { return srsDimensionField; }
      set { srsDimensionField = value; }
    }
  }
}