namespace Terradue.GeoJson.Gml
{
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
  [System.Xml.Serialization.XmlRootAttribute("AbstractTimePrimitive", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractTimePrimitiveType : AbstractTimeObjectType
  {

    private RelatedTimeType[] relatedTimeField;

    [System.Xml.Serialization.XmlElementAttribute("relatedTime")]
    public RelatedTimeType[] relatedTime
    {
      get { return relatedTimeField; }
      set { relatedTimeField = value; }
    }
  }
}