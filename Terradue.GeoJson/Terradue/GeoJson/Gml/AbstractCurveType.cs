namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CompositeCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OrientableCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (CurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (LineStringType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractCurve", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractCurveType : AbstractGeometricPrimitiveType
  {
  }
}