namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeTopologyComplexType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimePrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeTopologyPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeEdgeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeNodeType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractTimeGeometricPrimitiveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimePeriodType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (TimeInstantType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractTimeObject", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractTimeObjectType : AbstractGMLType
  {
  }
}