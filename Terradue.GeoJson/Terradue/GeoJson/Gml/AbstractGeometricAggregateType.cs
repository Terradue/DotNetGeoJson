namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiSolidType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiSurfaceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiCurveType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiPointType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (MultiGeometryType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractGeometricAggregate", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractGeometricAggregateType : AbstractGeometryType
  {

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}