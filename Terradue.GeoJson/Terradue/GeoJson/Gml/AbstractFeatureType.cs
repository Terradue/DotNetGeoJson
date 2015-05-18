namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (BoundedFeatureType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractFeatureCollectionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (FeatureCollectionType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ObservationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DirectedObservationAtDistanceType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (AbstractContinuousCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DiscreteCoverageType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DynamicFeatureType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (DynamicFeatureCollectionType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractFeature", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract partial class AbstractFeatureType : AbstractGMLType
  {

    private BoundingShapeType boundedByField;

    private LocationPropertyType itemField;

    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public BoundingShapeType boundedBy
    {
      get { return boundedByField; }
      set { boundedByField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("location", typeof (LocationPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("priorityLocation", typeof (PriorityLocationPropertyType))]
    public LocationPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}