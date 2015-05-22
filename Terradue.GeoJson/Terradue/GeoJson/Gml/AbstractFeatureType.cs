using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [XmlInclude(typeof (BoundedFeatureType))]
  [XmlInclude(typeof (AbstractFeatureCollectionType))]
  [XmlInclude(typeof (FeatureCollectionType))]
  [XmlInclude(typeof (ObservationType))]
  [XmlInclude(typeof (DirectedObservationType))]
  [XmlInclude(typeof (DirectedObservationAtDistanceType))]
  [XmlInclude(typeof (AbstractCoverageType))]
  [XmlInclude(typeof (AbstractContinuousCoverageType))]
  [XmlInclude(typeof (DiscreteCoverageType))]
  [XmlInclude(typeof (DynamicFeatureType))]
  [XmlInclude(typeof (DynamicFeatureCollectionType))]
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("AbstractFeature", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public abstract class AbstractFeatureType : AbstractGMLType
  {
    private BoundingShapeType boundedByField;
    private LocationPropertyType itemField;

    [XmlElement(IsNullable = true)]
    public BoundingShapeType boundedBy
    {
      get { return boundedByField; }
      set { boundedByField = value; }
    }

    [XmlElement("location", typeof (LocationPropertyType))]
    [XmlElement("priorityLocation", typeof (PriorityLocationPropertyType))]
    public LocationPropertyType Item
    {
      get { return itemField; }
      set { itemField = value; }
    }
  }
}